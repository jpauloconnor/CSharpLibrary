using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.AudioFormat;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace zSpeech
{
    public partial class zSpecchfrm : Form
    {
        public zSpecchfrm()
        {
            InitializeComponent();
        }

        #region Private members

        private List<Voice> Voices { get; set; }
        private SpeechSynthesizer Reader = new SpeechSynthesizer();
        private object _Lock = new object();

        #endregion

        #region Const

        const string ERR = "Error";
        const string INF = "Information";

        #endregion

        #region Form methods

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Voices = new List<Voice>();
                Reader.GetInstalledVoices().ToList().ForEach(v => Voices.Add(new Voice() { Name = v.VoiceInfo.Name, InstalledVoice = v }));
                cmbVoices.DataSource = Voices;
                cmbVoices.ValueMember = "InstalledVoice";
                cmbVoices.DisplayMember = "Name";
                cmbBit.SelectedIndex = 1;
                cmbChannel.SelectedIndex = 1;
                cmbHz.SelectedIndex = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ERR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtFileName.Text = saveFileDialog1.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ERR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            lock (_Lock)
            {
                try
                {
                    if (!string.IsNullOrEmpty(txtText.Text))
                    {
                        setStopPauseEnabled();

                        if (!string.IsNullOrEmpty(txtFileName.Text))
                            this.Cursor = Cursors.WaitCursor;

                        Reader = new SpeechSynthesizer();
                        Reader.SelectVoice(cmbVoices.Text);

                        AudioBitsPerSample audioBitsPerSample = (AudioBitsPerSample)Enum.Parse(typeof(AudioBitsPerSample), cmbBit.SelectedItem.ToString());
                        AudioChannel audioChannel = (AudioChannel)Enum.Parse(typeof(AudioChannel), cmbChannel.SelectedItem.ToString());

                        if (!string.IsNullOrEmpty(txtFileName.Text))
                            Reader.SetOutputToWaveFile(txtFileName.Text, new SpeechAudioFormatInfo(Convert.ToInt32(cmbHz.SelectedItem), audioBitsPerSample, audioChannel));

                        Reader.Rate = tbRate.Value;
                        Reader.SpeakAsync(txtText.Text);
                        cmdSave.Enabled = false;
                        Reader.SpeakCompleted += Reader_SpeakCompleted;
                    }
                    else
                    {
                        MessageBox.Show("Type the text that needs to be told", INF, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ERR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {

                }
            }
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            try
            {
                cmdPause.Enabled = false;
                cmdStop.Enabled = false;
                Reader.Dispose();
                cmdSave.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ERR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdPause_Click(object sender, EventArgs e)
        {
            try
            {
                if (Reader.State == SynthesizerState.Speaking)
                {
                    Reader.Pause();

                }
                else
                    if (Reader.State == SynthesizerState.Paused)
                    {
                        Reader.Resume();

                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ERR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Other

        private void setStopPauseEnabled()
        {
            if (string.IsNullOrEmpty(txtFileName.Text))
            {
                cmdPause.Enabled = true;
                cmdStop.Enabled = true;
            }
            else
            {
                cmdPause.Enabled = false;
                cmdStop.Enabled = false;
            }

        }
        void Reader_SpeakCompleted(object sender, System.Speech.Synthesis.SpeakCompletedEventArgs e)
        {
            try
            {
                cmdSave.Enabled = true;
                setStopPauseEnabled();
                Reader.SpeakCompleted -= Reader_SpeakCompleted;
                Reader.Dispose();

            }
            catch (ObjectDisposedException)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ERR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }
        #endregion


    }
}

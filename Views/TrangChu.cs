using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocTiengAnh.Views
{
    public partial class TrangChu : Form
    {
        // Khai báo delegate để nhận sự kiện từ form cha
        public delegate void OpenNewGame();
        public delegate void OpenAchievement();
        public delegate void OpenDictionary();
        public delegate void OpenInputInfo();
        // Khai báo event từ delegate
        public event OpenNewGame openNewGameHandler;
        public event OpenAchievement openAchievementHandler;
        public event OpenDictionary openDictionaryHandler;
        public event OpenInputInfo openInputInfoHandler;
        public TrangChu()
        {
            InitializeComponent();
        }

        public TrangChu(OpenInputInfo openInputInfo, OpenNewGame openNewGame, OpenAchievement openAchievement, OpenDictionary openDictionary)
        {
            InitializeComponent();
            this.openNewGameHandler = openNewGame;
            this.openAchievementHandler = openAchievement;
            this.openDictionaryHandler = openDictionary;
            this.openInputInfoHandler = openInputInfo;
            initSound();
        }

        private void BatDau_Click(object sender, EventArgs e)
        {
            openInputInfoHandler.Invoke();
            this.Close();
        }

        private void DiemSo_Click(object sender, EventArgs e)
        {
            openAchievementHandler.Invoke();
            this.Close();
        }

        private void TuDien_Click(object sender, EventArgs e)
        {
            openDictionaryHandler.Invoke();
            this.Close();
        }

        private void CheckBoxSound_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxSound.Checked)
            {
                Main.soundPlayer.PlayLooping();
                Main.CheckSoundBool = true;
            }
            else
            {
                Main.soundPlayer.Stop();
                Main.CheckSoundBool = false;
            }
        }

        public void initSound()
        {
            if (Main.CheckSoundBool)
            {
                CheckBoxSound.Checked = true;
            }
            else
            {
                CheckBoxSound.Checked = false;
            }
        }
    }
}

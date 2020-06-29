using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDU_InheritPractice
{
    public partial class PracticeForm : Form
    {
        Lifeform selectedTarget;

        private Neko creatureNeko;
        private Shimaenaga creatureShimaenaga;
        private Dacho creatureDacho;
        private Wani creatureWani;
        private Hebi creatureHebi;
        private Kaeru creatureKaeru;
        private Kabutomushi creatureKabuto;

        /// <summary>
        /// コンストラクター。
        /// </summary>
        public PracticeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// すべてのステータス表示欄を更新する。
        /// </summary>
        private void UpdateStatus()
        {
            if (creatureNeko != null) statusNeko.Text = creatureNeko.ToString();
            if (creatureShimaenaga != null) statusShimaenaga.Text = creatureShimaenaga.ToString();
            if (creatureDacho != null) statusDacho.Text = creatureDacho.ToString();
            if (creatureWani != null) statusWani.Text = creatureWani.ToString();
            if (creatureKaeru != null) statusKaeru.Text = creatureKaeru.ToString();
            if (creatureKabuto != null) statusKabutomushi.Text = creatureKabuto.ToString();

            if (selectedTarget != null) statusTarget.Text = selectedTarget.ToString();
        }

        #region "猫関連処理"

        /// <summary>
        /// 猫召喚ボタン押下時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void buttonNeko_Click(object sender, EventArgs e)
        {
            creatureNeko = new Neko("たま");
            creatureNeko.MaxLifePoint = 200 + new Random().Next(100);
            creatureNeko.LifePoint = creatureNeko.MaxLifePoint;
            statusNeko.Text = creatureNeko.ToString();
        }

        /// <summary>
        /// 猫ジャンプボタン押下時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void nekoJump_Click(object sender, EventArgs e)
        {
            if (creatureNeko != null)
            {
                if (creatureNeko.Jump())
                {
                    MessageBox.Show("ジャンプ成功");
                }
                else
                {
                    MessageBox.Show("ジャンプ失敗");
                }
            }
            // 状態表示更新
            statusNeko.Text = creatureNeko.ToString();
        }

        /// <summary>
        /// 猫走るボタン押下時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void nekoRun_Click(object sender, EventArgs e)
        {
            if (creatureNeko != null)
            {
                if (creatureNeko.Run())
                {
                    MessageBox.Show("走りました");
                }
                else
                {
                    MessageBox.Show("走れませんでした");
                }
            }
            // 状態表示更新
            statusNeko.Text = creatureNeko.ToString();
        }

        /// <summary>
        /// 猫止まるボタン押下時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void nekoStop_Click(object sender, EventArgs e)
        {
            if (creatureNeko != null)
            {
                if (creatureNeko.Stop())
                {
                    MessageBox.Show("止まれました");
                }
                else
                {
                    MessageBox.Show("止まれませんでした");
                }
                // 状態表示更新
                statusNeko.Text = creatureNeko.ToString();
            }
        }

        /// <summary>
        /// 猫噛むボタン押下時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void nekoBite_Click(object sender, EventArgs e)
        {
            if (creatureNeko != null)
            {
                int damageValue = creatureNeko.Bite();
                if (selectedTarget != null)
                {
                    MessageBox.Show("猫の噛み攻撃: ダメージ " + damageValue.ToString());
                    selectedTarget.LifePoint -= damageValue;
                    UpdateStatus();
                }
            }
        }

        /// <summary>
        /// 猫画像クリック時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void pictureCat_Click(object sender, EventArgs e)
        {
            if (creatureNeko != null)
            {
                selectedTarget = creatureNeko;
                pictureTarget.Image = pictureCat.Image;
                statusTarget.Text = creatureNeko.ToString();
            }
        }

        #endregion

        #region "シマエナガ関連処理"

        /// <summary>
        /// シマエナガ召喚ボタン押下時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void buttonShimaenaga_Click(object sender, EventArgs e)
        {
            creatureShimaenaga = new Shimaenaga("シマ");
            creatureShimaenaga.MaxLifePoint = 100 + new Random().Next(50);
            creatureShimaenaga.LifePoint = creatureShimaenaga.MaxLifePoint;
            statusShimaenaga.Text = creatureShimaenaga.ToString();
        }

        /// <summary>
        /// シマエナガ飛ぶボタン押下時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void shimaenagaFly_Click(object sender, EventArgs e)
        {
            if (creatureShimaenaga != null)
            {
                if (creatureShimaenaga.Fly())
                {
                    MessageBox.Show("飛びました");
                }
                else
                {
                    MessageBox.Show("飛べませんでした");
                }
                // 状態表示更新
                statusShimaenaga.Text = creatureShimaenaga.ToString();
            }
        }

        /// <summary>
        /// シマエナガ着地ボタン押下時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void shimaenagaLand_Click(object sender, EventArgs e)
        {
            if (creatureShimaenaga != null)
            {
                if (creatureShimaenaga.Land())
                {
                    MessageBox.Show("着地しました");
                }
                else
                {
                    MessageBox.Show("着地できませんでした");
                }
                // 状態表示更新
                statusShimaenaga.Text = creatureShimaenaga.ToString();
            }
        }

        /// <summary>
        /// シマエナガ突くボタン押下時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void shimaenagaThrust_Click(object sender, EventArgs e)
        {
            if (creatureShimaenaga != null)
            {
                int damageValue = creatureShimaenaga.Thrust();
                if (selectedTarget != null)
                {
                    MessageBox.Show("シマエナガの突き攻撃: ダメージ " + damageValue);
                    selectedTarget.LifePoint -= damageValue;
                    UpdateStatus();
                }
            }
        }

        /// <summary>
        /// シマエナガクリック時。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureShimaenaga_Click(object sender, EventArgs e)
        {
            if (creatureShimaenaga != null)
            {
                selectedTarget = creatureShimaenaga;
                pictureTarget.Image = pictureShimaenaga.Image;
                statusTarget.Text = creatureShimaenaga.ToString();
            }
        }

        #endregion

        #region "ダチョウ関連処理"

        /// <summary>
        /// ダチョウ召喚ボタン押下時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void buttonDacho_Click(object sender, EventArgs e)
        {
            creatureDacho = new Dacho("だちょ");
            creatureDacho.MaxLifePoint = 250 + new System.Random().Next(75);
            creatureDacho.LifePoint = creatureDacho.MaxLifePoint;
            statusDacho.Text = creatureDacho.ToString();
        }

        /// <summary>
        /// ダチョウ走るボタン押下時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void dachoRun_Click(object sender, EventArgs e)
        {
            if (creatureDacho != null)
            {
                if (creatureDacho.Run())
                {
                    MessageBox.Show("走りました。");
                }
                else
                {
                    MessageBox.Show("走れませんでした。");
                }
            }
            // 状態表示更新
            statusDacho.Text = creatureDacho.ToString();
        }

        /// <summary>
        /// ダチョウ止まるボタン押下時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void dachoStop_Click(object sender, EventArgs e)
        {
            if (creatureDacho != null)
            {
                if (creatureDacho.Stop())
                {
                    MessageBox.Show("止まれました。");
                }
                else
                {
                    MessageBox.Show("止まれませんでした。");
                }
            }
            // 状態表示更新
            statusDacho.Text = creatureDacho.ToString();
        }

        /// <summary>
        /// ダチョウ突くボタン押下時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void dachoTrust_Click(object sender, EventArgs e)
        {
            if (creatureDacho != null)
            {
                int damageValue = creatureDacho.Thrust();
                if (selectedTarget != null)
                {
                    MessageBox.Show("ダチョウの突き攻撃: ダメージ " + damageValue);
                    selectedTarget.LifePoint -= damageValue;
                    UpdateStatus();
                }
            }
        }

        /// <summary>
        /// ダチョウ蹴るボタン押下時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void dachoKick_Click(object sender, EventArgs e)
        {
            if (creatureDacho != null)
            {
                int damageValue = creatureDacho.Kick();
                if (selectedTarget != null)
                {
                    MessageBox.Show("ダチョウの蹴り攻撃: ダメージ " + damageValue);
                    selectedTarget.LifePoint -= damageValue;
                    UpdateStatus();
                }
            }
        }

        /// <summary>
        /// ダチョウ画像クリック時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void pictureDacho_Click(object sender, EventArgs e)
        {
            if (creatureDacho != null)
            {
                selectedTarget = creatureDacho;
                pictureTarget.Image = pictureDacho.Image;
                statusTarget.Text = creatureDacho.ToString();
            }
        }

        #endregion

        #region "ワニ関連処理"

        /// <summary>
        /// ワニ召喚ボタン押下時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void buttonWani_Click(object sender, EventArgs e)
        {
            creatureWani = new Wani("わに");
            creatureWani.MaxLifePoint = 200 + new System.Random().Next(50);
            creatureWani.LifePoint = creatureWani.MaxLifePoint;
            statusWani.Text = creatureWani.ToString();
        }

        /// <summary>
        /// ワニ脱皮ボタン押下時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void waniDappi_Click(object sender, EventArgs e)
        {
            if (creatureWani != null)
            {
                if (creatureWani.Moult())
                {
                    MessageBox.Show("脱皮できました。");
                }
            }
        }

        /// <summary>
        /// ワニ噛むボタン押下時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void waniBite_Click(object sender, EventArgs e)
        {
            if (creatureWani != null)
            {
                int damageValue = creatureWani.Bite();
                if (selectedTarget != null)
                {
                    MessageBox.Show("ワニの噛みつき攻撃: ダメージ " + damageValue);
                    selectedTarget.LifePoint -= damageValue;
                    UpdateStatus();
                }
            }
        }

        /// <summary>
        /// ワニ画像クリック時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void pictureWani_Click(object sender, EventArgs e)
        {
            if (creatureWani != null)
            {
                selectedTarget = creatureWani;
                pictureTarget.Image = pictureWani.Image;
                statusTarget.Text = creatureWani.ToString();
            }
        }

        #endregion

        #region "ヘビ関連処理"

        /// <summary>
        /// ヘビ召喚ボタン押下時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void buttonHebi_Click(object sender, EventArgs e)
        {
            creatureHebi = new Hebi("はぶ");
            creatureHebi.MaxLifePoint = 120 + new System.Random().Next(30);
            creatureHebi.LifePoint = creatureHebi.MaxLifePoint;
            statusHebi.Text = creatureHebi.ToString();
        }

        /// <summary>
        /// 蛇脱皮ボタン押下時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void hebiDappi_Click(object sender, EventArgs e)
        {
            if (creatureHebi != null)
            {
                if (creatureHebi.Moult())
                {
                    MessageBox.Show("脱皮できました。");
                }
            }
        }

        /// <summary>
        /// 蛇噛むボタン押下時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void hebiBite_Click(object sender, EventArgs e)
        {
            if (creatureHebi != null)
            {
                int damageValue = creatureHebi.Bite();
                if (selectedTarget != null)
                {
                    MessageBox.Show("ヘビの噛みつき攻撃: ダメージ " + damageValue);
                    selectedTarget.LifePoint -= damageValue;
                    UpdateStatus();
                }
            }
        }

        /// <summary>
        /// ヘビ画像クリック時処理
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void pictureHabu_Click(object sender, EventArgs e)
        {
            if (creatureHebi != null)
            {
                selectedTarget = creatureHebi;
                pictureTarget.Image = pictureHabu.Image;
                statusTarget.Text = creatureHebi.ToString();
            }
        }

        #endregion

        #region "蛙関連処理"

        /// <summary>
        /// カエル召喚ボタン押下時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void buttonKaeru_Click(object sender, EventArgs e)
        {
            creatureKaeru = new Kaeru("ケロ");
            creatureKaeru.MaxLifePoint = 80 + new System.Random().Next(40);
            creatureKaeru.LifePoint = creatureKaeru.MaxLifePoint;
            statusKaeru.Text = creatureKaeru.ToString();
        }

        /// <summary>
        /// カエル画像クリック時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void pictureKaeru_Click(object sender, EventArgs e)
        {
            if (creatureKaeru != null)
            {
                selectedTarget = creatureKaeru;
                pictureTarget.Image = pictureKaeru.Image;
                statusTarget.Text = creatureKaeru.ToString();
            }
        }

        #endregion

        #region "カブトムシ関連処理"

        /// <summary>
        /// カブトムシ召喚ボタン押下時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void buttonKabutomushi_Click(object sender, EventArgs e)
        {
            creatureKabuto = new Kabutomushi("かぶと");
            creatureKabuto.MaxLifePoint = 200 + new System.Random().Next(100);
            creatureKabuto.LifePoint = creatureKabuto.MaxLifePoint;
            statusKabutomushi.Text = creatureKabuto.ToString();
        }

        /// <summary>
        /// カブトムシ画像クリック時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void pictureBeetle_Click(object sender, EventArgs e)
        {
            if (creatureKabuto != null)
            {
                selectedTarget = creatureKabuto;
                pictureTarget.Image = pictureBeetle.Image;
                statusTarget.Text = creatureKabuto.ToString();
            }
        }

        #endregion

        private void buttonCreateLife_Click(object sender, EventArgs e)
        {
            Lifeform theRiddle = new Lifeform();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IEggCreatable ranseiCreature;

            ranseiCreature = creatureDacho;
            ranseiCreature = creatureKabuto;

            this.Dispose();
        }
    }
}

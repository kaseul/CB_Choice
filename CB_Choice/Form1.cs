using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CB_Choice
{
    public partial class Form1 : Form
    {
        // 초기 ComboBox 데이터 설정
        string[] SList = new string[] { "김밥", "샐러드김밥", "야채김밥", "소고기김밥", "계란김밥", "라볶이" };
        string orgStr = ""; // 선택 결과 저장

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < SList.Length; i++) {
                this.cbList.Items.Add(SList[i]);
            }

            this.orgStr = this.lblResult.Text;

            if(this.SList.Length > 0)
            {
                this.cbList.SelectedIndex = 0;
            }
            
        }

        private void CbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblResult.Text = this.orgStr + this.cbList.Text;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            CheckInput();            
        }

        private void TxtList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                CheckInput();
            }
        }

        private bool CheckInput()
        {
            if (this.txtList.Text == "")
            {
                MessageBox.Show("추가할 항목을 입력해주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtList.Focus();

                return false;
            }
            else
            {
                this.cbList.Items.Add(this.txtList.Text);
                this.txtList.Text = "";
                this.txtList.Focus();
                this.cbList.SelectedIndex = this.cbList.Items.Count - 1;

                return true;
            }
        }
    }
}

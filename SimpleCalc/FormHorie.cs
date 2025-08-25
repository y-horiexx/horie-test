using System;

namespace SimpleCalc
{
    public partial class Form_Horie : Form
    {
        public Form_Horie()
        {
            // フォームのUIコンポーネントを初期化
            InitializeComponent();
        }

        // 計算ボタンがクリックされたときのメイン処理
        private void CalcButton_Click(object sender, EventArgs e)
        {
            // 変数定義
            int valueLeft;
            int valueRight;
            int valueAnswer;
            bool isLeftValid;
            bool isRightValid;

            // 入力チェック→結果をtrue or falseで取得
            isLeftValid = InputCheck(Input1TextBox.Text, out valueLeft);
            isRightValid = InputCheck(Input2TextBox.Text, out valueRight);

            // 両方とも数値入力の場合：エラーメッセージを非表示
            if (isLeftValid == true && isRightValid == true)
            {
                // 加算処理
                valueAnswer = valueLeft + valueRight;

                // 結果表示
                answerTextBox.Text = valueAnswer.ToString();

                // エラーメッセージ非表示
                errorLabel.Visible = false;
            }
            else
            {
                // 両方とも文字列入力の場合：エラーメッセージを表示
                if (isLeftValid == false && isRightValid == false)
                {
                    errorLabel.Text = $"{Input1TextBox.Text}と{Input2TextBox.Text}は0として計算しました";
                }
                // 左側のみ文字列入力の場合：エラーメッセージを表示
                else if (isLeftValid == false)
                {
                    errorLabel.Text = $"{Input1TextBox.Text}は0として計算しました";
                }
                // 右側のみ文字列入力の場合：エラーメッセージを表示
                else
                {
                    errorLabel.Text = $"{Input2TextBox.Text}は0として計算しました";
                }

                // エラーメッセージの文字色を赤にして、視覚的に強調
                errorLabel.ForeColor = Color.Red;
                errorLabel.Visible = true;
            }
        }

        // 入力値チェックメソッド：文字列をint型に変換できるか判定
        private bool InputCheck(string textValue, out int value)
        {
            if (int.TryParse(textValue, out value) == true)
            {
                // int.TryParse変換成功：valueに変換された数値が入る
                return true;
            }
            else
            {
                // int.TryParse変換失敗：valueを0に設定して、falseを返す
                value = 0;
                return false;
            }
        }
    }
}

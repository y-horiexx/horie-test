using System;

namespace SimpleCalc
{
    public partial class Form_Horie : Form
    {
        public Form_Horie()
        {
            // �t�H�[����UI�R���|�[�l���g��������
            InitializeComponent();
        }

        // �v�Z�{�^�����N���b�N���ꂽ�Ƃ��̃��C������
        private void CalcButton_Click(object sender, EventArgs e)
        {
            // �ϐ���`
            int valueLeft;
            int valueRight;
            int valueAnswer;
            bool isLeftValid;
            bool isRightValid;

            // ���̓`�F�b�N�����ʂ�true or false�Ŏ擾
            isLeftValid = InputCheck(Input1TextBox.Text, out valueLeft);
            isRightValid = InputCheck(Input2TextBox.Text, out valueRight);

            // �����Ƃ����l���͂̏ꍇ�F�G���[���b�Z�[�W���\��
            if (isLeftValid == true && isRightValid == true)
            {
                // ���Z����
                valueAnswer = valueLeft + valueRight;

                // ���ʕ\��
                answerTextBox.Text = valueAnswer.ToString();

                // �G���[���b�Z�[�W��\��
                errorLabel.Visible = false;
            }
            else
            {
                // �����Ƃ���������͂̏ꍇ�F�G���[���b�Z�[�W��\��
                if (isLeftValid == false && isRightValid == false)
                {
                    errorLabel.Text = $"{Input1TextBox.Text}��{Input2TextBox.Text}��0�Ƃ��Čv�Z���܂���";
                }
                // �����̂ݕ�������͂̏ꍇ�F�G���[���b�Z�[�W��\��
                else if (isLeftValid == false)
                {
                    errorLabel.Text = $"{Input1TextBox.Text}��0�Ƃ��Čv�Z���܂���";
                }
                // �E���̂ݕ�������͂̏ꍇ�F�G���[���b�Z�[�W��\��
                else
                {
                    errorLabel.Text = $"{Input2TextBox.Text}��0�Ƃ��Čv�Z���܂���";
                }

                // �G���[���b�Z�[�W�̕����F��Ԃɂ��āA���o�I�ɋ���
                errorLabel.ForeColor = Color.Red;
                errorLabel.Visible = true;
            }
        }

        // ���͒l�`�F�b�N���\�b�h�F�������int�^�ɕϊ��ł��邩����
        private bool InputCheck(string textValue, out int value)
        {
            if (int.TryParse(textValue, out value) == true)
            {
                // int.TryParse�ϊ������Fvalue�ɕϊ����ꂽ���l������
                return true;
            }
            else
            {
                // int.TryParse�ϊ����s�Fvalue��0�ɐݒ肵�āAfalse��Ԃ�
                value = 0;
                return false;
            }
        }
    }
}

  private void button1_Click(object sender, EventArgs e)
        {
            switch(Convert.ToInt32(textBox1.Text))
            {
                case 1:
                    MessageBox.Show("Понедельник", "День недели", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                case 2:
                    MessageBox.Show("Вторник", "День недели", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 3:
                    MessageBox.Show("Среда", "День недели", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 4:
                    MessageBox.Show("Четверг", "День недели", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 5:
                    MessageBox.Show("Пятница", "День недели", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 6:
                    MessageBox.Show("Суббота", "День недели", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 7:
                    MessageBox.Show("Воскресенье", "День недели", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show("Неизвестно", "День недели", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
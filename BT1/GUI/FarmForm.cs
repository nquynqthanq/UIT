using BLL;
using DAL;
using System;
using System.Linq; // For Count extension method
using System.Windows.Forms;

namespace GUI
{
    public partial class FarmForm : Form
    {
        private Farm farm;

        public FarmForm()
        {
            InitializeComponent();
            farm = new Farm();
        }

        private void btnAddAnimals_Click(object sender, EventArgs e)
        {
            bool isCowCountValid = int.TryParse(txtCowCount.Text, out int cowCount);
            bool isSheepCountValid = int.TryParse(txtSheepCount.Text, out int sheepCount);
            bool isGoatCountValid = int.TryParse(txtGoatCount.Text, out int goatCount);

            if ((!isCowCountValid || cowCount < 0) &&
                (!isSheepCountValid || sheepCount < 0) &&
                (!isGoatCountValid || goatCount < 0))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho tất cả số lượng gia súc.", "Lỗi Nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((cowCount == 0 && sheepCount == 0 && goatCount == 0) ||
                (!isCowCountValid && !isSheepCountValid && !isGoatCountValid))
            {
                MessageBox.Show("Vui lòng nhập số lượng cho ít nhất một loại gia súc.", "Lỗi Nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (isCowCountValid && cowCount > 0)
            {
                farm.AddAnimal(new Cow(), cowCount);
            }
            if (isSheepCountValid && sheepCount > 0)
            {
                farm.AddAnimal(new Sheep(), sheepCount);
            }
            if (isGoatCountValid && goatCount > 0)
            {
                farm.AddAnimal(new Goat(), goatCount);
            }


            txtCowCount.Clear();
            txtSheepCount.Clear();
            txtGoatCount.Clear();

            MessageBox.Show("Gia súc đã được thêm vào trang trại!");
        }



        private void btnMakeSounds_Click(object sender, EventArgs e)
        {
            if (farm.Animals.Count == 0)
            {
                MessageBox.Show("Hiện tại không có gia súc trong trang trại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sounds = farm.GetAllAnimalSounds();
                MessageBox.Show(sounds);
            }
        }

        private void btnGetStatistics_Click(object sender, EventArgs e)
        {
            if (farm.Animals.Count == 0)
            {
                MessageBox.Show("Hiện tại không có gia súc trong trang trại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int totalMilk = 0;
            int totalOffspring = 0;
            int totalCows = 0;
            int totalSheep = 0;
            int totalGoats = 0;
            int cowsBorn = 0;
            int sheepBorn = 0;
            int goatsBorn = 0;

            foreach (var animal in farm.Animals)
            {
                totalMilk += animal.ProduceMilk();
                totalOffspring += animal.GiveBirth();

                if (animal is Cow)
                {
                    totalCows += animal.Count;
                    cowsBorn += animal.GiveBirth();
                }
                else if (animal is Sheep)
                {
                    totalSheep += animal.Count;
                    sheepBorn += animal.GiveBirth();
                }
                else if (animal is Goat)
                {
                    totalGoats += animal.Count;
                    goatsBorn += animal.GiveBirth();
                }
            }

            MessageBox.Show($"Số lượng gia súc hiện tại:\n" +
                            $"Bò: {totalCows}\n" +
                            $"Cừu: {totalSheep}\n" +
                            $"Dê: {totalGoats}\n\n" +
                            $"Số lượng con sinh ra:\n" +
                            $"Bò: {cowsBorn}\n" +
                            $"Cừu: {sheepBorn}\n" +
                            $"Dê: {goatsBorn}\n\n" +
                            $"Số lượng sữa được lấy: {totalMilk} liters", "Thông tin thống kê", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void btnClearAnimals_Click(object sender, EventArgs e)
        {
            farm.Animals.Clear();
            MessageBox.Show("Tất cả gia súc đã được xóa khỏi trang trại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

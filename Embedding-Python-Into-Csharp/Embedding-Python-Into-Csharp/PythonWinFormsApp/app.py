import clr
import os

# Thêm thư viện .NET cần thiết
clr.AddReference("System.Windows.Forms")

from System.Windows.Forms import Application, Form, Button, PictureBox
from System.Drawing import Image

# Đường dẫn lưu file
output_file = os.path.abspath("output_chart.png")

# Gọi mã Python
def run_drawing_script():
    import drawing_script
    drawing_script.draw_chart(output_file)
    return output_file

# Tạo Form chính
class MainForm(Form):
    def __init__(self):
        self.Text = "Python.NET Drawing App"
        self.Width = 600
        self.Height = 400

        # Nút vẽ
        self.btn_draw = Button()
        self.btn_draw.Text = "Draw Chart"
        self.btn_draw.Top = 10
        self.btn_draw.Left = 10
        self.btn_draw.Click += self.on_draw_click
        self.Controls.Add(self.btn_draw)

        # Hộp hiển thị hình ảnh
        self.picture_box = PictureBox()
        self.picture_box.Top = 50
        self.picture_box.Left = 10
        self.picture_box.Width = 560
        self.picture_box.Height = 300
        self.Controls.Add(self.picture_box)

    def on_draw_click(self, sender, args):
        # Chạy mã vẽ
        try:
            file_path = run_drawing_script()
            self.picture_box.Image = Image.FromFile(file_path)
        except Exception as e:
            print(f"Error: {e}")

# Chạy ứng dụng
if __name__ == "__main__":
    Application.Run(MainForm())

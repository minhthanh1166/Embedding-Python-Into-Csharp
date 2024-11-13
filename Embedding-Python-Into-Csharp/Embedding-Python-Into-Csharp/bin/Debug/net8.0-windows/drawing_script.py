# import matplotlib.pyplot as plt
# import numpy as np

# def draw_chart(output_file):
#     """
#     Vẽ biểu đồ và lưu thành tệp hình ảnh.
#     """
#     x = np.linspace(0, 10, 100)
#     y = np.sin(x)

#     plt.figure(figsize=(6, 4))
#     plt.plot(x, y, label="sin(x)", color="blue")
#     plt.title("Sine Wave")
#     plt.xlabel("X-axis")
#     plt.ylabel("Y-axis")
#     plt.legend()
#     plt.grid(True)

#     # Lưu biểu đồ vào file
#     plt.savefig(output_file)
#     plt.close()


import matplotlib.pyplot as plt
import numpy as np

def draw_chart(output_file):
    # Tạo dữ liệu
    x = np.linspace(0, 10, 500)  # Tạo dãy số từ 0 đến 10 với 500 điểm
    y1 = np.sin(x)               # Hàm sin(x)
    y2 = np.cos(x)               # Hàm cos(x)

    # Tạo figure và axes
    plt.figure(figsize=(10, 6), dpi=100)  # Đặt kích thước và độ phân giải

    # Vẽ đồ thị sin(x)
    plt.plot(x, y1, label="sin(x)", color="blue", linestyle="-", linewidth=2, alpha=0.8)

    # Vẽ đồ thị cos(x)
    plt.plot(x, y2, label="cos(x)", color="orange", linestyle="--", linewidth=2, alpha=0.8)

    # Thêm lưới
    plt.grid(color="gray", linestyle=":", linewidth=0.5)

    # Đặt tiêu đề
    plt.title("Beautiful Sin & Cos Plot", fontsize=16, fontweight="bold")

    # Đặt nhãn trục x và y
    plt.xlabel("X-axis (Time)", fontsize=12)
    plt.ylabel("Y-axis (Amplitude)", fontsize=12)

    # Thêm chú thích
    plt.legend(loc="upper right", fontsize=12)

    # Đặt giới hạn cho trục y
    plt.ylim(-1.5, 1.5)

    # Làm đẹp trục
    plt.xticks(fontsize=10)
    plt.yticks(fontsize=10)

    plt.legend()
    plt.grid(True)

    # Lưu biểu đồ vào file
    plt.savefig(output_file)
    plt.close()

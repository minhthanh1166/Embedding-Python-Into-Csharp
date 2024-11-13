import matplotlib.pyplot as plt
import numpy as np

def draw_chart(output_file):
    """
    Vẽ biểu đồ và lưu thành tệp hình ảnh.
    """
    x = np.linspace(0, 10, 100)
    y = np.sin(x)

    plt.figure(figsize=(6, 4))
    plt.plot(x, y, label="sin(x)", color="blue")
    plt.title("Sine Wave")
    plt.xlabel("X-axis")
    plt.ylabel("Y-axis")
    plt.legend()
    plt.grid(True)

    # Lưu biểu đồ vào file
    plt.savefig(output_file)
    plt.close()

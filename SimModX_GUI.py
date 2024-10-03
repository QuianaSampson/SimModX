import sys
from PyQt5.QtWidgets import QApplication, QMainWindow, QLabel

class SimModXApp(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setWindowTitle("SimModX GUI")
        self.setGeometry(100, 100, 600, 400)
        self.initUI()

    def initUI(self):
        label = QLabel("Welcome to SimModX!", self)
        label.move(200, 150)

if __name__ == '__main__':
    app = QApplication(sys.argv)
    mainWindow = SimModXApp()
    mainWindow.show()
    sys.exit(app.exec_())

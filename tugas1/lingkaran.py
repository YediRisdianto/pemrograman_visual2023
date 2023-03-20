from tkinter import Frame, Label, Entry, Button, YES, BOTH, END, Tk, W


class FrmLingkaran:
    def __init__(self, parent, title):
        self.parent = parent
        self.parent.geometry("500x500")
        self.parent.title(title)
        self.parent.protocol("WM_DELETE_WINDOW", self.Keluar)
        self.aturKomponen()

    def aturKomponen(self):
        mainFrame = Frame(self.parent, bd=10)
        mainFrame.pack(fill=BOTH, expand=YES)
        # pasang Label
        Label(mainFrame, text='Jari Jari :').grid(
            row=0, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas:").grid(
            row=2, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling:").grid(
            row=3, column=0, sticky=W, padx=5, pady=5)
        
        # pasang textbox
        self.txtjari = Entry(mainFrame)
        self.txtjari.grid(row=0, column=1, padx=5, pady=5)
        self.txtLuas = Entry(mainFrame)
        self.txtLuas.grid(row=2, column=1, padx=5, pady=5)
        self.txtKeliling = Entry(mainFrame)
        self.txtKeliling.grid(row=3, column=1, padx=5, pady=5)

        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung',
                                command=self.Hitung)
        self.btnHitung.grid(row=1, column=1, padx=5, pady=5)
    
    # fungsi untuk menghitung luas dan keliling lingkaran

    def Hitung(self, event=None):
        # perhitungan dengan metode Pemrograman Terstruktur
        jari = float(self.txtjari.get())

        bunder = lingkaran(jari)
        luas = bunder.luas()
        kel = bunder.keliling()

        self.txtLuas.delete(0, END)
        self.txtLuas.insert(END, str(luas))
        self.txtKeliling.delete(0, END)
        self.txtKeliling.insert(END, str(kel))

    def Keluar(self, event=None):
        # memberikan perintah menutup aplikasi
        self.parent.destroy()


class lingkaran():
    # perhitungan dengan metode Pemrograman OOP
    def __init__(self, jari):
        self.jari = jari

    def luas(self):
        return 3.14 * (self.jari * self.jari)

    def keliling(self):
        return 2 * 3.14 * self.jari


if __name__ == '__main__':
    root = Tk()
    aplikasi = FrmLingkaran(root, "OOP! Program Luas dan Keliling Lingkaran")
    root.mainloop()

from tkinter import Frame, Label, Entry, Button, YES, BOTH, END, Tk, W


class FrmLayang:
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
        Label(mainFrame, text='Diagonal 1 :').grid(
            row=0, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Diagonal 2 :').grid(
            row=1, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi Pendek Layang :').grid(
            row=2, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi Panjang Layang :').grid(
            row=3, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas:").grid(
            row=5, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling:").grid(
            row=6, column=0, sticky=W, padx=5, pady=5)
        
        # pasang textbox
        self.txtdiagonal1 = Entry(mainFrame)
        self.txtdiagonal1.grid(row=0, column=1, padx=5, pady=5)
        self.txtdiagonal2 = Entry(mainFrame)
        self.txtdiagonal2.grid(row=1, column=1, padx=5, pady=5)
        self.txtsisiPendek = Entry(mainFrame)
        self.txtsisiPendek.grid(row=2, column=1, padx=5, pady=5)
        self.txtsisiPanjang = Entry(mainFrame)
        self.txtsisiPanjang.grid(row=3, column=1, padx=5, pady=5)
        self.txtLuas = Entry(mainFrame)
        self.txtLuas.grid(row=5, column=1, padx=5, pady=5)
        self.txtKeliling = Entry(mainFrame)
        self.txtKeliling.grid(row=6, column=1, padx=5, pady=5)

        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung',
                                command=self.Hitung)
        self.btnHitung.grid(row=4, column=1, padx=5, pady=5)

    # fungsi untuk menghitung luas dan keliling layang-layang

    def Hitung(self, event=None):
        # perhitungan dengan metode Pemrograman Terstruktur
        d1 = int(self.txtdiagonal1.get())
        d2 = int(self.txtdiagonal2.get())
        sisiPendek = int(self.txtsisiPendek.get())
        sisiPanjang = int(self.txtsisiPanjang.get())

        lyg = layang(d1, d2, sisiPendek, sisiPanjang)
        luas = lyg.luas()
        kel = lyg.keliling()

        self.txtLuas.delete(0, END)
        self.txtLuas.insert(END, str(luas))
        self.txtKeliling.delete(0, END)
        self.txtKeliling.insert(END, str(kel))

    def Keluar(self, event=None):
        # memberikan perintah menutup aplikasi
        self.parent.destroy()


class layang():
    # perhitungan dengan metode Pemrograman OOP
    def __init__(self, d1, d2, sisiPendek, sisiPanjang):
        self.d1 = d1
        self.d2 = d2
        self.sisiPendek = sisiPendek
        self.sisiPanjang = sisiPanjang

    def luas(self):
        return 1/2 * (self.d1 * self.d2)

    def keliling(self):
        return 2 * (self.sisiPendek + self.sisiPanjang)


if __name__ == '__main__':
    root = Tk()
    aplikasi = FrmLayang(root, "OOP! Program Luas dan Keliling Layang Layang")
    root.mainloop()

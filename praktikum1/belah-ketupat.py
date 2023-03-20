from tkinter import Frame, Label, Entry, Button, YES, BOTH, END, Tk, W


class FrmBelahKetupat:
    def __init__(self, parent, title):
        self.parent = parent
        self.parent.geometry("400x400")
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
        Label(mainFrame, text='Sisi :').grid(
            row=2, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas :").grid(
            row=4, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling :").grid(
            row=5, column=0, sticky=W, padx=5, pady=5)
        
        # pasang textbox
        self.txtdiagonal1 = Entry(mainFrame)
        self.txtdiagonal1.grid(row=0, column=1, padx=5, pady=5)
        self.txtdiagonal2 = Entry(mainFrame)
        self.txtdiagonal2.grid(row=1, column=1, padx=5, pady=5)
        self.txtsisi = Entry(mainFrame)
        self.txtsisi.grid(row=2, column=1, padx=5, pady=5)
        self.txtLuas = Entry(mainFrame)
        self.txtLuas.grid(row=4, column=1, padx=5, pady=5)
        self.txtKeliling = Entry(mainFrame)
        self.txtKeliling.grid(row=5, column=1, padx=5, pady=5)

        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung',
                                command=self.Hitung)
        self.btnHitung.grid(row=3, column=1, padx=5, pady=5)

    # fungsi untuk menghitung luas dan keliling belah ketupat

    def Hitung(self, event=None):

        # perhitungan dengan metode Pemrograman Terstruktur
        d1 = int(self.txtdiagonal1.get())
        d2 = int(self.txtdiagonal2.get())
        sisi = int(self.txtsisi.get())
        luas, kel = self.belahketupat(d1, d2, sisi)

        self.txtLuas.delete(0, END)
        self.txtLuas.insert(END, str(luas))
        self.txtKeliling.delete(0, END)
        self.txtKeliling.insert(END, str(kel))

    def belahketupat(self, d1, d2, sisi):
        luas = 1/2 * (d1*d2)
        kel = 4 * sisi
        return luas, kel

    def Keluar(self, event=None):
        # memberikan perintah menutup aplikasi
        self.parent.destroy()


if __name__ == '__main__':
    root = Tk()
    aplikasi = FrmBelahKetupat(root, "Program Luas dan Keliling Belah Ketupat")
    root.mainloop()

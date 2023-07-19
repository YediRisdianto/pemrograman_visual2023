from tkinter import Frame, Label, Entry, Button, YES, BOTH, END, Tk, W


class FrmTrapesium:
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
        Label(mainFrame, text='Alas a :').grid(
            row=0, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Alas b :').grid(
            row=1, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Tinggi :').grid(
            row=2, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi a:').grid(
            row=3, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi b:').grid(
            row=4, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi c:').grid(
            row=5, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi d:').grid(
            row=6, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas :").grid(
            row=8, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling :").grid(
            row=9, column=0, sticky=W, padx=5, pady=5)
        
        # pasang textbox
        self.txtalasA = Entry(mainFrame)
        self.txtalasA.grid(row=0, column=1, padx=5, pady=5)
        self.txtalasB = Entry(mainFrame)
        self.txtalasB.grid(row=1, column=1, padx=5, pady=5)
        self.txttinggi = Entry(mainFrame)
        self.txttinggi.grid(row=2, column=1, padx=5, pady=5)
        self.txtsisiA = Entry(mainFrame)
        self.txtsisiA.grid(row=3, column=1, padx=5, pady=5)
        self.txtsisiB = Entry(mainFrame)
        self.txtsisiB.grid(row=4, column=1, padx=5, pady=5)
        self.txtsisiC = Entry(mainFrame)
        self.txtsisiC.grid(row=5, column=1, padx=5, pady=5)
        self.txtsisiD = Entry(mainFrame)
        self.txtsisiD.grid(row=6, column=1, padx=5, pady=5)
        self.txtLuas = Entry(mainFrame)
        self.txtLuas.grid(row=8, column=1, padx=5, pady=5)
        self.txtKeliling = Entry(mainFrame)
        self.txtKeliling.grid(row=9, column=1, padx=5, pady=5)

        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung',
                                command=self.Hitung)
        self.btnHitung.grid(row=7, column=1, padx=5, pady=5)

    # fungsi untuk menghitung luas dan keliling trapesium

    def Hitung(self, event=None):
        # perhitungan dengan metode Pemrograman Terstruktur
        alasA = int(self.txtalasA.get())
        alasB = int(self.txtalasB.get())
        tinggi = int(self.txttinggi.get())
        sisiA = int(self.txtsisiA.get())
        sisiB = int(self.txtsisiB.get())
        sisiC = int(self.txtsisiC.get())
        sisiD = int(self.txtsisiD.get())
        luas, kel = self.trapesium(
            alasA, alasB, tinggi, sisiA, sisiB, sisiC, sisiD)

        self.txtLuas.delete(0, END)
        self.txtLuas.insert(END, str(luas))
        self.txtKeliling.delete(0, END)
        self.txtKeliling.insert(END, str(kel))

    def trapesium(self, alasA, alasB, tinggi, sisiA, sisiB, sisiC, sisiD):
        luas = 1/2 * (alasA + alasB) * tinggi
        kel = sisiA + sisiB + sisiC + sisiD
        return luas, kel

    def Keluar(self, event=None):
        # memberikan perintah menutup aplikasi
        self.parent.destroy()


if __name__ == '__main__':
    root = Tk()
    aplikasi = FrmTrapesium(root, "Program Luas dan Keliling Trapesium")
    root.mainloop()

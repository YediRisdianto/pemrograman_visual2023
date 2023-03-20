from tkinter import Frame, Label, Entry, Button, YES, BOTH, END, Tk, W


class FrmTrapesium:
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
        self.txtalasa = Entry(mainFrame)
        self.txtalasa.grid(row=0, column=1, padx=5, pady=5)
        self.txtalasb = Entry(mainFrame)
        self.txtalasb.grid(row=1, column=1, padx=5, pady=5)
        self.txttinggi = Entry(mainFrame)
        self.txttinggi.grid(row=2, column=1, padx=5, pady=5)
        self.txtsisia = Entry(mainFrame)
        self.txtsisia.grid(row=3, column=1, padx=5, pady=5)
        self.txtsisib = Entry(mainFrame)
        self.txtsisib.grid(row=4, column=1, padx=5, pady=5)
        self.txtsisic = Entry(mainFrame)
        self.txtsisic.grid(row=5, column=1, padx=5, pady=5)
        self.txtsisid = Entry(mainFrame)
        self.txtsisid.grid(row=6, column=1, padx=5, pady=5)
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
        alasa = int(self.txtalasa.get())
        alasb = int(self.txtalasb.get())
        tinggi = int(self.txttinggi.get())
        sisia = int(self.txtsisia.get())
        sisib = int(self.txtsisib.get())
        sisic = int(self.txtsisic.get())
        sisid = int(self.txtsisid.get())

        trapes = trapesium(alasa, alasb, tinggi, sisia, sisib, sisic, sisid)
        luas = trapes.luas()
        kel = trapes.keliling()

        self.txtLuas.delete(0, END)
        self.txtLuas.insert(END, str(luas))
        self.txtKeliling.delete(0, END)
        self.txtKeliling.insert(END, str(kel))

    def Keluar(self, event=None):
        # memberikan perintah menutup aplikasi
        self.parent.destroy()


class trapesium():
    # perhitungan dengan metode Pemrograman OOP
    def __init__(self, alasa, alasb, tinggi, sisia, sisib, sisic, sisid):
        self.alasa = alasa
        self.alasb = alasb
        self.tinggi = tinggi
        self.sisia = sisia
        self.sisib = sisib
        self.sisic = sisic
        self.sisid = sisid

    def luas(self):
        return 1/2 * (self.alasa + self.alasb) * self.tinggi

    def keliling(self):
        return self.sisia + self.sisib + self.sisic + self.sisid


if __name__ == '__main__':
    root = Tk()
    aplikasi = FrmTrapesium(root, "OOP! Program Luas dan Keliling Trapesium")
    root.mainloop()

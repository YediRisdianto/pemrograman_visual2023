from tkinter import Frame, Label, Entry, Button, YES, BOTH, END, Tk, W


class FrmPersegi:
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
        Label(mainFrame, text='Sisi :').grid(
            row=0, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas:").grid(
            row=2, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling:").grid(
            row=3, column=0, sticky=W, padx=5, pady=5)
        
        # pasang textbox
        self.txtSisi = Entry(mainFrame)
        self.txtSisi.grid(row=0, column=1, padx=5, pady=5)
        self.txtLuas = Entry(mainFrame)
        self.txtLuas.grid(row=2, column=1, padx=5, pady=5)
        self.txtKeliling = Entry(mainFrame)
        self.txtKeliling.grid(row=3, column=1, padx=5, pady=5)

        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung',
                                command=self.Hitung)
        self.btnHitung.grid(row=1, column=1, padx=5, pady=5)

    # fungsi untuk menghitung luas dan keliling persegi

    def Hitung(self, event=None):

        # perhitungan dengan metode Pemrograman Terstruktur
        sisi = int(self.txtSisi.get())
        luas, kel = self.persegi(sisi)

        self.txtLuas.delete(0, END)
        self.txtLuas.insert(END, str(luas))
        self.txtKeliling.delete(0, END)
        self.txtKeliling.insert(END, str(kel))

    def persegi(self, sisi):
        luas = sisi * sisi
        kel = 4 * sisi
        return luas, kel

    def Keluar(self, event=None):
        # memberikan perintah menutup aplikasi
        self.parent.destroy()


if __name__ == '__main__':
    root = Tk()
    aplikasi = FrmPersegi(root, "Program Luas dan Keliling Persegi")
    root.mainloop()

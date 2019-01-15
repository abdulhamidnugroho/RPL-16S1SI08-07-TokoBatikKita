
CREATE TABLE BARANG(
ID_BARANG CHAR (10) PRIMARY KEY ,
NAMA_BARANG VARCHAR(60) NOT NULL,
HARGA_BELI NUMERIC(18,0),
HARGA_JUAL NUMERIC(18,0),
STOK INT,
)

CREATE TABLE SUPPLIER(
ID_SUPPLIER CHAR (10) PRIMARY KEY ,
NAMA VARCHAR(50) NOT NULL,
ALAMAT VARCHAR(50),
NO_TELEPON VARCHAR(12),
)

CREATE TABLE KARYAWAN(
ID_KARYAWAN CHAR (10) PRIMARY KEY ,
NAMA VARCHAR(50) NOT NULL,
PASSWORDS VARCHAR(50),
HAK_AKSES VARCHAR(10),
)

INSERT INTO KARYAWAN VALUES ('4000001','GALANG','GALANG','OWNER')
INSERT INTO KARYAWAN VALUES ('4000002','HAMID','HAMID','KARYAWAN')

CREATE TABLE PELANGGAN(
ID_PELANGGAN CHAR (10) PRIMARY KEY ,
NAMA VARCHAR(50) NOT NULL,
ALAMAT VARCHAR(50),
NO_HP VARCHAR(12),
JENISKELAMIN VARCHAR(10)
)

CREATE TABLE OPERASIONAL(
ID_KARYAWAN CHAR (10) FOREIGN KEY REFERENCES KARYAWAN(ID_KARYAWAN),
TANGGAL DATETIME NOT NULL,
JENIS_PENGELUARAN VARCHAR(40),
NOMINAL_PENGELUARAN NUMERIC (25,0),
NOMINAL_PEMASUKAN NUMERIC (25,0)
)

CREATE TABLE PENJUALAN(
ID_NOTAJUAL CHAR (10) PRIMARY KEY ,
TANGGAL DATETIME NOT NULL,
TOTAL NUMERIC(30,0),
ID_PELANGGAN CHAR (10) FOREIGN KEY REFERENCES PELANGGAN(ID_PELANGGAN),
ID_KARYAWAN CHAR (10) FOREIGN KEY REFERENCES KARYAWAN(ID_KARYAWAN),
DIBAYAR NUMERIC(30,0),
KEMBALI NUMERIC(30,0),
JUMLAH_BARANG INT,
DISKON NUMERIC(15,0)
)

ALTER TABLE PENJUALAN
ALTER COLUMN KEMBALI NUMERIC(30,0)



CREATE TABLE ITEM_PENJUALAN(
ID_NOTAJUAL CHAR (10) FOREIGN KEY REFERENCES PENJUALAN(ID_NOTAJUAL),
ID_BARANG CHAR (10) FOREIGN KEY REFERENCES BARANG(ID_BARANG),
NAMA_BARANG VARCHAR(25),
HARGA_JUAL NUMERIC(30,0),
JUMLAH INT,
SUBTOTAL NUMERIC(30,0)
)

ALTER TABLE ITEM_PENJUALAN
ALTER COLUMN SUBTOTAL NUMERIC(30,0)

CREATE TABLE PEMBELIAN(
ID_NOTABELI CHAR (10) PRIMARY KEY ,
TANGGAL DATETIME NOT NULL,
TOTAL NUMERIC(30,0),
ID_SUPPLIER CHAR (10) FOREIGN KEY REFERENCES SUPPLIER(ID_SUPPLIER),
ID_KARYAWAN CHAR (10) FOREIGN KEY REFERENCES KARYAWAN(ID_KARYAWAN),
DIBAYAR NUMERIC(30,0),
KEMBALI NUMERIC(30,0),
DISKON NUMERIC(15,0)
)

ALTER TABLE PEMBELIAN
ALTER COLUMN DIBAYAR NUMERIC(30,0)

CREATE TABLE ITEM_PEMBELIAN(
ID_NOTABELI CHAR (10) FOREIGN KEY REFERENCES PEMBELIAN(ID_NOTABELI),
ID_BARANG CHAR (10) FOREIGN KEY REFERENCES BARANG(ID_BARANG),
NAMA_BARANG VARCHAR(25),
HARGA_BELI NUMERIC(18,0),
JUMLAH INT,
SUBTOTAL NUMERIC(25,0)
)

ALTER TABLE ITEM_PEMBELIAN
ALTER COLUMN SUBTOTAL NUMERIC(30,0)

INSERT INTO BARANG VALUES ('000000','BATIK',20000,30000,20)
INSERT INTO BARANG VALUES ('B000001','BATIK',20000,30000,20)
INSERT INTO BARANG VALUES ('B000002','BATIK KAEL',25000,40000,20)
INSERT INTO BARANG VALUES ('B000003','BATIK xl',25000,40000,20)
INSERT INTO BARANG VALUES ('40002','BATIK x4',25000,40000,20)
INSERT INTO BARANG VALUES ('B0005','BATIK x2',25000,40000,20)
INSERT INTO BARANG VALUES ('B0006','BATIK x2',26000,50000,10)
INSERT INTO BARANG VALUES ('10000','BATIK x2',26000,50000,10)
INSERT INTO BARANG VALUES ('1000001','BESI',30000,50000,10)

INSERT INTO PELANGGAN VALUES ('2000001','RISNU','BAWURAN',08122765354,'LAKI-LAKI')
INSERT INTO SUPPLIER VALUES ('3000001','RINO','TABURAN',08122765354)


SELECT * from barang
SELECT * from OPERASIONAL
SELECT * from penjualan
SELECT * from ITEM_PENJUALAN
SELECT * from ITEM_PEMBELIAN
select * from pembelian
select * from KARYAWAN

delete from operasional where ID_KARYAWAN = NOMINAL_PEMASUKAN='3500000'
update operasional set tanggal = '2018-12-28 00:00:00:000'
where NOMINAL_PEMASUKAN='3500000' and ID_KARYAWAN='4000002'

delete from penjualan where ID_NOTAJUAL = '1812160001'
delete from ITEM_PENJUALAN where ID_NOTAJUAL = '1812160001'
delete from pembelian where ID_NOTAbeli = '1812160003'
delete from ITEM_PEMBELIAN where ID_NOTAbeli = '1812160003'
delete from barang where id_barang = 'B0005'
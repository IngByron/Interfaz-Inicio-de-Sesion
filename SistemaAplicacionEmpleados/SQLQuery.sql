select *from usuarios
UPDATE USUARIOS
SET CONSTRASENA = (PWDENCRYPT('admi')) WHERE USUARIO='4dm1';
Delete USUARIOS where USUARIO='4dm1'

insert into USUARIOS(NOMBRE, USUARIO, CONTRASENA) values('Administrador','4dm1',PWDENCRYPT('admi'));

Select usuario, contrasena from USUARIOS where usuario='4dm1' and PWDCOMPARE('admi',contrasena)=1
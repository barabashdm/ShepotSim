# ShepotSim
diploma work (c#, winforms,mysql(mariadb)), simulation of "SOZ Shepot" for educational purposes

Без подключения к БД программа не работает

Для входа:
Администратор (преподаватель) Барабаш Д.М. - логин admin, пароль 12345
Пользователь Иванов И.И. - логин ivanovii12, пароль pass1234
Пользователь Красильников - логин krasii, пароль kras123
Пользователь Прохорец - логин prohor123, пароль 123123

Баги: в программе иногда при создании пользователя или смене пароля не получается зайти (какая-то проблема с хешированием). Данные стеклопакета для генерации могут вызвать зависание, т.к. превышают требования и нет счетчика подсчета при перегенерации с выдачей ошибки. При добавлении двух человек в одну группу: люди будут отображаться в обособленных одинаковых группах (не успел исправить).

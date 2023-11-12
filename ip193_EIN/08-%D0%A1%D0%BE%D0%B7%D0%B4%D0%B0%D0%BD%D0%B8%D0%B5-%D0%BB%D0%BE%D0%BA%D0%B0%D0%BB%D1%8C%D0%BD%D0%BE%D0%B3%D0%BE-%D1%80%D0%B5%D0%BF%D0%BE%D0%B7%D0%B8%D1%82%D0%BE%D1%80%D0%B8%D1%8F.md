1. Создайте локальный репозиторий из папки с решением ```SportStore```.
2. Проинициализируйте репозиторий командой ```git init```
3. Свяжите локальный и удаленный репозитории командой ```git remote add origin <ссылка на удаленный репозиторий>```
4. Пропишите локальный конфиг: 
    ```git config --local user.name "ФИО студента"```
    ```git config --local user.email "Группа студента@git.scc"```
5. Скачайте с удаленного репозитория в локальные файлы ```.gitignore``` и ```README.md``` командой ```git pull origin master```
6. Скачайте в ресурсах файл ```README-template-rus.md``` и напишите свой ```README.md``` в соответствии с шаблоном.
7. Добавьте в локальный репозиторий файлы ```database.sql```,```SportStore.sql``` и ERD-диаграмму.
8. ```git add .```
9. ```git commit -m "Intro"```
10. ```git push origin master``` или (```git push origin master -f```)
11. Проверьте синхронизацию локального и удаленного репозиториев.
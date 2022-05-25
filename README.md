# rx-template-microservice
Шаблон заказного микросервиса с API интерфейсом

В решении 2 проекта:
* CustomWebAPI - ASP .NET Core веб приложение, можно использовать шаблон для реализации сайтов и веб-сервисов
* CustomJobHandler - консольное приложение, можно использовать для реализации легковесных гибко настраиваемых агентов, не требующих обработки запросов

## Порядок запуска микросервиса средствами ServiceRunner (только для Windows):
1. Выполнить публикацию проекта Self-Contained.
2. Содержимое заархивировать в zip, назвать <sevice_name>.zip, рекомендуется назвать аналогично проекту, иначе предварительно поправить имя в _PackageInfo.json.
3. Скопировать архив в \etc\_builds_package
4. На основе _ConfigSettings.xml.example создать _ConfigSettings.xml в папке \etc\_services_config\<sevice_name>
5. Добавить в конфиге ServiceRunner'а (\etc\_services_config\ServiceRunner) строку:
<ServiceSetting Name="<sevice_name>" Config="<sevice_name>\_ConfigSettings.xml" Package="<sevice_name>.zip" ConfigWatcherEnabled="false" Disabled="false" />
# Что это и для чего

Мод для Lucky Tower Ultimate в основном для помощи спидраннерам как для сбора инфы, так и для самих ранов для поиска нужной генерации

## Специальные спасибо
[Черная магия вуду](https://github.com/avail/UnityAssemblyInjector) - длл инжектор на плюсах для юнити, без этого мне было бы лень разбираться самому  
[elwycco](https://www.twitch.tv/elwycco) и [AlcoreRu](https://www.twitch.tv/alcoreru) - ну врать не стану мне стало интересно как работает башня после хз знает скольки часов их соревнования

## Как установить

Скачиваем [DLL Injector](https://github.com/avail/UnityAssemblyInjector) и устанавливем в папку с игрой по инструкции из репы  
Скачиваем последнюю релизную версию мода отсюда - [Релиз](https://github.com/sloosli/LuckyRunner/releases) и разархивируем в папу с игрой  
Запускаем игру и видим надпись слева-сверху (Если надпись не видим, то идем устанавливать [Net Framework 4.6 Runtime](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net462))

## Как использовать

`F5` Переключение режимов  
Они цикличны:
1) `SegmentInfo` - Показывает информацию по всем дверям текущего сегмента(работает если в хабе), а также инфу по текущей комнате и настроению Злодеюса, ближе к читу чем к моду, но отлично для теста кода и сбора инфы по игре
3) `OnlyBalcony` - Показывает только через сколько этажей будет шорт(в пределах сегмента и если игрок в комнате-хабе), отлично для спидрана что бы заранее понять нужен ли рестарт, но все равно сохранить рандомность и тактики поиска балкона
4) `Off` - Выключено

## Как удалить
Удалите все что закинули в папку с игрой

## Как собрать самому
Клонируете репу к себе, в проджект файле подправьте переменку `GamePath` что бы она вела до корневой папки игры  
По идее должно собираться сразу

## Если не работает
Ну что поделать

## Примеры использования 

`SegmentInfo`

![image](https://github.com/user-attachments/assets/30eb595d-808a-47a1-8bfe-80a264790cbb)

`OnlyBalcony`

![image](https://github.com/user-attachments/assets/6bbddebd-a0b9-4008-bc42-3c0f57f31263)

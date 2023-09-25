# portfolio-backend-dotnet

Template for Net 7 framework with PostgreSQL database

## Предварительная настройка

1. Установите `dotnet-ef`, для этого откройте консоль диспетчера пакетов, вставьте и выполните следующую команду:

```
  dotnet tool install --global dotnet-ef
```

## Создание БД с помощью CLI

1. Запустите сборку проекта:

```
  dotnet build
```

2. Запустите команду на создание миграции

```
  dotnet ef migrations add InitialCreate
```

3. Обновите БД

```
  dotnet ef database update
```
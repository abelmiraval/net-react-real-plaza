
## Run project

- Create migrations
```
dotnet ef migrations add Init-Migration --project .\RealPlaza.DataAccess\ --startup-project .\RealPlaza.API\
```

- Update database
```
dotnet ef database update --project .\RealPlaza.DataAccess\ --startup-project .\RealPlaza.API\
```

- Run watch
````

````
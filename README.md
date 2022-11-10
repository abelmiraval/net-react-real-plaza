

# Backend 

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
dotnet watch run --project .\RealPlaza.API\
````

- Service
```
http://localhost:5000/api/products?page=2&rows=6&orderBy=DESC&price=5000
```

![Postman, Postman](/images/postman.png)


# Frontend

- Run project

```
npm start serve
```

- Pantalla con filtro precio mayor
![Pantalla, Pantalla](/images/pantalla_1.png)


- Pantalla con filtro precio menor
![Pantalla, Pantalla](/images/pantalla_2.png)

- Pantalla con rango precio
![Pantalla, Pantalla](/images/pantalla_3.png)


- Pantalla con paginacion
![Pantalla, Pantalla](/images/pantalla_4.png)
# Rest API Clean Architecture

- [Rest API Clean Architecture](#Rest-API-Clean-Architecture)
	- [Auth](#auth)
		- [Register](#resgister)
			- [Register request](#register-request)
			- [Register response](#register-response)
		- [Login](#login)
			- [Login request](#login-request)
			- [Login response](#loign-response)

## Auth

### Register

```js
POST {{host}}/auth/register
```

#### Register request

```json
{
	"firstName": "Ho",
	"lastName: "Huy",
	"email": "vanhuyhvh2k4@gmail.com",
	"password": "123"
}
```
#### Register response

```js
200 OK
```

```json
{
	"id": "c1c1df46-a90d-4e94-b1f7-5e65af929456",
	"firstName": "Ho",
	"lastName"" "Huy",
	"email": "vanhuyhvh2k4@gmail.com",
	"token": "eyJhb.z9Dgnxs"
}
```

### Login

```js
POST {{host}}/auth/login
```
#### Login request

```json
{
	"email": "vanhuyhvh2k4@gmail.com",
	"password": "123"
}
```

#### Login response
```js
200 Ok
```

```json
{
	"id": "c1c1df46-a90d-4e94-b1f7-5e65af929456",
	"firstName": "Ho",
	"lastName" "Huy",
	"email": "vanhuyhvh2k4@gmail.com",
	"token": "eyJhb.z9Dgnxs"
}
```
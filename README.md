# Bristol ZingTech HMRC-HR API

## Getting started

### Pre-requisites:

- [Docker](https://docs.docker.com/get-docker/) and [Docker Compose](https://docs.docker.com/compose/install/). (Docker Desktop for Mac is recommended)

### Setup

1.  Clone this repo.

2.  Run the service locally: `docker-compose up -d --build`.

3.  Perform the database migrations: `docker-compose exec api dotnet dotnet-ef database update`<sup>1</sup>

4.  Access the API at `http://localhost:8080/api/<endpoint>` (e.g. `http://localhost:8080/api/employeedata`)

## Running tests

### Unit tests

`Insert comments about our unit testing strategy here. How do we approach unit testing of this API so we're testing our business logic and not the ASP.NET framework?`

### Integration tests

We use [integration tests](https://martinfowler.com/articles/practical-test-pyramid.html#IntegrationTests) to mean tests that make HTTP requests to our service and then assert on the return value.

No test doubles are used. Instead, a local production-like PostgreSQL database is created for testing. This means new integration tests must fill the database with test data in the arrange step if required.

To run integration tests:

1.  Start the service (see [Setup](#Setup)).

2.  Run the tests using [Newman](https://github.com/postmanlabs/newman): `npm exec newman run <project_root>/backend-tests/integration/*`

## Footnotes

1.  Database migrations require both the `db` and `api` containers to be _ready_ (not just running), which is not guaranteed if migrations are run in the `docker-compose` step. It's safer to run `docker-compose` first then execute the migrations once that has completed with `docker-compose exec`.

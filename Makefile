# Project DependancyInjectionProject

PROJECT_NAME ?= DependancyInjectionProject

.PHONY: migrations db

migrations:
	cd ./DependancyInjectionProject.Data && dotnet ef --startup-project ../DependancyInjectionProject.Web migrations add $(mname) && cd ..

db:
	cd ./DependancyInjectionProject.Data && dotnet ef --startup-project ../DependancyInjectionProject.Web/ database update && cd ..

test:
	echo "testing"

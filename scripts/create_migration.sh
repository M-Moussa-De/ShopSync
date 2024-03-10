#!/bin/bash

migrationName=$1

# projectDir=$2
projectDir="../backend/ShopSync.Infrastructure"

# Check if migration name is provided
if [ -z $migrationName ]
then
    echo "Error: No migration name provided. Please provide a migration name."
    exit 1
fi

# Check if project directory is provided
# if [ ! -d $projectDir ]
# then
#     echo "Error: Project directory not found. Please provide a valid project directory."
#     exit 1
# fi

cd $projectDir

dotnet ef migrations add $migrationName -o ./Migrations

# dotnet ef database update
#!/bin/bash

projectDir="../backend/ShopSync.Infrastructure"

cd $projectDir

echo "y" | dotnet ef database update
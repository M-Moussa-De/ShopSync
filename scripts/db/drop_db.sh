#!/bin/bash

projectDir="../backend/ShopSync.Infrastructure"

cd "$projectDir"

# Drop the database
echo "y" | dotnet ef database drop

# Check the exit code of the last command
if [ $? -ne 0 ]; then
    echo "Error: Failed to drop the database. Please check the logs for more details."
else
    echo "Success: Database dropped successfully."
fi

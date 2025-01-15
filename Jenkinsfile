pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                git 'https://github.com/AbdallahHesham44/dep-oy-in-windows.git'
            }
        }
        
        stage('Build') {
            steps {
                script {
                    // Build the project
                    bat 'dotnet build ConsoleApp1/ConsoleApp1.csproj'
                }
            }
        }
        
        stage('Run') {
            steps {
                script {
                    // Run the project
                    bat 'dotnet run --project ConsoleApp1/ConsoleApp1.csproj'
                }
            }
        }
    }
}

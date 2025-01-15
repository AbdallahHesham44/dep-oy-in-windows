pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                git branch: 'main', url: 'https://github.com/AbdallahHesham44/dep-oy-in-windows.git'
            }
        }

        stage('Build') {
            steps {
                script {
                    try {
                        bat 'dotnet build ConsoleApp1/ConsoleApp1.csproj'
                    } catch (Exception e) {
                        error "Build failed: ${e.message}"
                    }
                }
            }
        }

        stage('Run') {
            steps {
                script {
                    try {
                        bat 'dotnet run --project ConsoleApp1/ConsoleApp1.csproj'
                    } catch (Exception e) {
                        error "Run failed: ${e.message}"
                    }
                }
            }
        }
    }
}

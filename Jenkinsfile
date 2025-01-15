pipeline {
    agent any
    stages {
        stage('Build') {
            steps {
                script {
                    if (isUnix()) {
                        sh 'dotnet --version'
                        sh 'dotnet build'
                    } else {
                        bat 'dotnet build'
                    }
                }
            }
        }
        stage('Run') {
            steps {
                script {
                    if (isUnix()) {
                        sh 'dotnet run'
                    } else {
                        bat 'dotnet run'
                    }
                }
            }
        }
    }
}

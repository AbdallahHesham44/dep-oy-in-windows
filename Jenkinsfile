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
                        bat 'dotnet publish -c Release -r win-x64 --self-contained -o publish'
                    } catch (Exception e) {
                        error "Build failed: ${e.message}"
                    }
                }
            }
        }

        stage('Run') {
            steps {
                dir('publish') {
                    script {
                        try {
                            bat '''
                            if not exist "C:\\Users\\Abdallah Hesham\\source\\repos\\ConsoleApp1\\logs" (
                                mkdir "C:\\Users\\Abdallah Hesham\\source\\repos\\ConsoleApp1\\logs"
                            )
                            start /b ConsoleApp1.exe
                            '''
                        } catch (Exception e) {
                            error "Run failed: ${e.message}"
                        }
                    }
                }
            }
        }
    }

    post {
        success {
            echo 'Pipeline completed successfully. Application is running in the background.'
        }
    }
}

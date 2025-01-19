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
                      //  bat 'dotnet build ConsoleApp1/ConsoleApp1.csproj'
                        bat 'dotnet publish -c Release -r win-x64 --self-contained -o ..\\publish' 
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
                       // bat 'dotnet run --project ConsoleApp1/ConsoleApp1.csproj'
             bat '''
             
     if not exist "C:\\Users\\Abdallah Hesham\\source\\repos\\ConsoleApp1\\logs" mkdir "C:\\Users\\Abdallah Hesham\\source\\repos\\ConsoleApp1\\logs"
       
               start /B dotnet .\\publish\\ConsoleApp1.dll 
        
                '''
                    } catch (Exception e) {
                        error "Run failed: ${e.message}"
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

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
                        bat 'dotnet publish -c Release -r win-x64 --self-contained -o ./publish' 
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
              REM print working dir
              cd
              dir
                REM start ./publish/ConsoleApp1
               start /B  .\\publish\\ConsoleApp1 > "C:\\Users\\Abdallah Hesham\\source\\repos\\ConsoleApp1\\logs\\app.log" 2>&1
                echo %ERRORLEVEL%
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

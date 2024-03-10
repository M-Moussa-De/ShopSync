pipeline {
    agent any
    
    stages {
        
        stage('Clear Workspace') {
            steps {
                cleanWs()
            }
        }

        stage('Git Checkout') {
           steps {
               echo 'Checking out the code..'
               git branch: 'main', credentialsId: 'github', url: 'https://github.com/M-Moussa-De/ShopSync.git'
            }
        }
        
        stage('Build app') {
            steps {
                dir('./backend') {
                    script{
                        try {
                            docker.build("api-sv", "-f Dockerfile.dev .")
                        } catch (Exception e) {
                            echo "Failed to build API project: ${e.message}"
                            currentBuild.result = 'FAILURE'
                        }
                    }
               }
            }
        }
    }          
}
const { codegen } = require('swagger-axios-codegen')
codegen({
  methodNameMode: 'path',
  remoteUrl:'http://localhost:48513/swagger/v1/swagger.json'
})
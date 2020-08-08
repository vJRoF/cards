module.exports = {
  configureWebpack: {
    devtool: 'source-map'
  },
  devServer: {
    proxy: {
      '^/api': {
        target: 'http://localhost:48513',
        ws: true,
        changeOrigin: true
      }
    }
  },
  transpileDependencies: [
    'vuetify'
  ]
}
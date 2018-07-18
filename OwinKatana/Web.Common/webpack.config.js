var path = require('path')

module.exports = {
	entry: ['./src/app.jsx'],
	output: {
		filename: 'bundle.js',
		path: path.resolve(__dirname, '../Web/dist')
	},
	devtool: 'source-maps',
	mode: 'development',
	module: {
		rules: [
			{
				test: /\.jsx?$/,
				exclude: /node_modules/,
				use: {
					loader: 'babel-loader',
					options: {
						presets: ['@babel/preset-env', '@babel/preset-react']
					}
				}
			}
		]
	}

}
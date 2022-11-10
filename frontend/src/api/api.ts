import axios from 'axios';

const instance = axios.create({
	baseURL: 'https://localhost:5001/api',
	headers: {
		'Content-Type': 'application/json'
	}
});

export default instance;

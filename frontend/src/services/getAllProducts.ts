import axios from 'axios';
import { Product, ProductResponse } from '../types';

export const getAllProducts = () => {
  return fetchProducts();
};

const fetchProducts = async (): Promise<ProductResponse> => {
  const response = await axios.get('http://localhost:3001/products');

  return response.data;
};

import { useContext } from 'react';
import { ProductContext } from '../context/ProductContext';

export const useProduct = () => {
	const { productState, handleChangeSelect, handleChangeInput, getAllProducts } = useContext(ProductContext);
	const { products, price, minPrice, maxPrice, orderBy } = productState;

	return {
		products: products,
		price: price,
		minPrice: minPrice,
		maxPrice: maxPrice,
		orderBy: orderBy,
		handleChangeSelect,
		handleChangeInput,
		getAllProducts
	};
};

import { useContext } from 'react';
import { ProductContext } from '../context/ProductContext';

export const usePagination = () => {
	const { productState, getAllProducts, nextPage, prevPage } = useContext(ProductContext);
	const { products, price, orderBy, page, totalPage } = productState;

	const canNextPage = () => {
		const currentPage = page + 1;
		const lastPage = Math.ceil(totalPage / 6);
		return currentPage !== lastPage;
	};

	const canPrevPage = () => {
		return page !== 0;
	};

	return {
		products: products,
		price: price,
		orderBy: orderBy,
		page: page,
		getAllProducts: getAllProducts,
		nextPage: nextPage,
		prevPage: prevPage,
		canNextPage,
		canPrevPage
	};
};

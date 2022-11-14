import { useContext } from 'react';
import { ProductContext } from '../context/ProductContext';

export const usePagination = () => {
	const { productState, nextPage, prevPage } = useContext(ProductContext);
	const { page, totalPage } = productState;

	const canNextPage = () => {
		return page === totalPage;
	};

	const canPrevPage = () => {
		return page === 1;
	};

	return {
		nextPage,
		prevPage,
		canNextPage,
		canPrevPage
	};
};

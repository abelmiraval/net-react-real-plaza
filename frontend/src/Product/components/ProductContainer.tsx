import React from 'react';
import { ProductFilter } from './ProductFilter/ProductFilter';
import { ProductList } from './ProductList/ProductList';
import { ProductPagination } from './ProductPagination/ProductPagination';

export default function RoomContainer() {
	return (
		<div>
			<ProductFilter />
			<ProductList />
			<ProductPagination />
			<br />
		</div>
	);
}

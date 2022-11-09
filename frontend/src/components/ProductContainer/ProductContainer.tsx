import React from 'react';
import ProductFilter from '../ProductFilter/ProductFilter';
import ProductList from '../ProductList/ProductList';

export default function RoomContainer() {
    return (
        <div>
            <ProductFilter />
            <ProductList />
        </div>
    );
}

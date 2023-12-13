@extends('layouts.product')

@section('title', 'lista')

@section('content')
    <h1>Lista produktów</h1>
    <table>
        <thead>
            <tr>
                <td>Nazwa produktu</td>
                <td>Cena produktu</td>
                <td>Opis produktu</td>
            </tr>
        </thead>
        <tbody>
            @foreach($products as $product)
                <tr>
                    <td>{{ $product->name }}</td>
                    <td>{{ $product->price }}</td>
                    <td>{{ $product->description }}</td>
                    <td>
                        <a href="{{ route('product.show', $product->id) }}">Szczegóły</a>
                        <a href="{{ route('product.edit', $product->id) }}">Edytuj</a>
                        <form action="{{ route('product.destroy', $product->id) }}" method="post" style="display: inline-block;">
                            @csrf
                            @method('DELETE')
                            <button type="submit" onclick="return confirm('Czy na pewno chcesz usunąć produkt?')">Usuń</button>
                        </form>
                    </td>
                </tr>

            @endforeach
        </tbody>
    </table>
@endsection

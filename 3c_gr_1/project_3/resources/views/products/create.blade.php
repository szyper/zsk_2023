<h3>Dodawanie produktu</h3>
<div>
    <form action="{{route('product.store')}}" method="post">
        @csrf
        <button type="submit">Dodaj produkt</button>
    </form>
</div>

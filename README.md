# xamarinforms-mask-behaviors
Aplicando máscaras em campos do tipo Entry, facilitando assim a digitação pelo usuário.

Exemplo abaixo mostra como usar pra formatar Data no formato DD/MM/YYYY.
```
<Entry Placeholder="DD/MM/YYYY"
       Keyboard="Numeric"
       HorizontalTextAlignment="Center">
  <Entry.Behaviors>
    <helper:MaskBehaviorEntry MaxLength="10" Tipo="Data"/>
  </Entry.Behaviors>
</Entry>
```

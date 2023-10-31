# BCSH2_BDAS2_Pohunek_Krska
Semestrální práce BCSH2
Databázová aplikace pro závody koloběžek
Lukáš Pohůnek, Jakub Krška
Frontend:
• Intuitivní design
• Náhledy do databáze – zřejmě Data grid view
• Funkční tlačítka pro operace s databází
• Odstraňování a přidávání do databáze
Databáze :
• • Každý závodník musí mít alespoň jednu koloběžku, aby mohl být evidován.
• • Jedna osoba nemůže být zároveň závodník a zaměstnanec.
• • Koloběžka nemůže být zároveň elektro a normální.
• • Na UID u entity Turnaj bude nastaven sekvenční trigger.
• • Název v tabulce Sponzoři musí být unikátní.
• • V tabulce Účastníci závodu bude vytvořen index pro sloupce: „id_zavod,
• id_ucastnik_zavodu“.
• PROCEDURÁLNÍ PRAVIDLA:
• • Přístup do databáze je možný pouze skrze firemní intranet. Je tedy vyžadována
• VPN, nebo kabelové připojení k firemní síti.
• • Jeden závodník se nemůže zúčastnit více závodů ve stejný čas.
• • Jeden zaměstnanec se nemůže účastnit více závodů ve stejný čas.
• • Startovné musí být zaplaceno minimálně 3 dny před startem závodu.
• Integritní omezení (IO)
• IO1: Maximální výkon Elektrokoloběžky je 1000 W.
• IO2: Minimální hodnota startovného je 200 Kč.
• IO3: Úroveň oprávnění může obsahovat pouze hodnoty <1; 4>

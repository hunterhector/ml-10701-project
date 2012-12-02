3. Transfer English IE annotations and nounphrase boundaries to French via the mechanism described in Yarowsky et al.(2001), yielding annotated sentence pairs as illustrated in Figure 1.
H01-1035
For English, we applied the base noun phrase chunker supplied with the fnTBL toolkit (Ngai & Florian, 2001).
N01-1006
4 Transformation-Based Learning We used transformation-based learning (TBL) (Brill, 1995) to learn information extraction rules for French.
J95-4004
of Projection The cross-language projection methodology employed in this paper is based on Yarowsky et al.(2001), with one important exception.
H01-1035
Many techniques have been developed to generate extraction patterns for a new domain automatically, including PALKA (Kim & Moldovan, 1993), AutoSlog (Riloff, 1993), CRYSTAL (Soderland et al., 1995), RAPIER (Califf, 1998), SRV (Freitag, 1998), meta-bootstrapping (Riloff & Jones, 1999), and ExDisco (Yangarber et al., 2000).
C00-2136 P98-1067
Yarowsky et al.(2001) developed cross-language projection models for part-of-speech tags, base noun phrases, named-entity tags, and morphological analysis (lemmatization) for four languages.
H01-1035
Word-align the parallel corpus using the Giza++ system (Och and Ney, 2000).
P00-1056
In French, we ran a part-of-speech tagger (Cucerzan & Yarowsky, 2000) and applied regular-expression heuristics to detect the heads of noun phrases.
P00-1035

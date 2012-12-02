It can also be considered as an extension from the monolingual to the bilingual case of the well-established methods for semantic or syntactic word clustering as proposed by Schtitze (1993), Grefenstette (1994), Ruge (1995), Rapp (1996), Lin (1998), and others.
P98-2127
By presupposing a lexicon of seed words, she avoids the prohibitively expensive computational effort encountered by Rapp (1995).
P95-1050
(According to Lezius, Rapp, & Wettler, 1998, 93% of the tokens of a German text had only one lemma).
P98-2123
This was true in 89 cases, s For comparison, Fung & McKeown (1997) report an accuracy of about 30% when only the top candidate is counted.
W97-0119
Of course, in practice due to omissions, transpositions, insertions, and replacements in the process of translation with real texts there may be all kinds of problems, and therefore robustness is still an issue (Langlais et al., 1998).
P98-1117
Another approach, as conducted by Fung & Yee (1998), would be to consider all possible translations listed in the lexicon and to give them equal (or possibly descending) weight.
P98-1069
They were based on mutual information (Church & Hanks, 1989), conditional probabilities (Rapp, 1996), or on some standard statistical tests, such as the chi-square test or the loglikelihood ratio (Dunning, 1993).
J93-1003 P89-1010
Although we had a context-sensitive lemmatizer for German available (Lezius, Rapp, & Wettler, 1998), this was not the case for English, so for reasons of symmetry we decided not to use the context feature.
P98-2123
It is faster and more mnemonic than the one in Dunning (1993).
J93-1003
Starting with the well-known paper of Brown et al.(1990) on statistical machine translation, there has been much scientific interest in the alignment of sentences and words in translated texts.
J90-2002
524 German test word Baby Brot Frau gelb H~iuschen Kind Kohl Krankheit M~idchen Musik Ofen pfeifen Religion Schaf Soldat StraBe siiB Tabak weiB Whisky expected translation and rank baby 1 bread 1 woman 2 yellow 1 cottage 2 child 1 cabbage 17074 sickness 86 baby bread man yellow bungalow child Major disease top five translations as automatically generated child mother daughter father cheese meat food butter woman boy friend wife blue red pink green cottage house hut village daughter son father mother Kohl Thatcher Gorbachev Bush illness Aids patient doctor girl 1 girl music 1 music dance stove 3 heat oven stove house whistle 3 linesman referee whistle blow offside religion 1 sheep 1 soldier 1 street 2 boy man brother lady theatre musical song burn religion culture faith religious belief sheep cattle cow pig goat soldier army troop force civilian road street city town walk sweet smell delicious taste love sweet 1 tobacco 1 white 46 whiskey 11 tobacco cigarette consumption nicotine drink know say thought see think whisky beer Scotch bottle wine Table 1: Results for 20 of the 100 test words (for full list see http://www.fask.uni-mainz.de/user/rappl) 5 Discussion and Conclusion The method described can be seen as a simple case of the gradient descent method proposed by Rapp (1995), which does not need an initial lexicon but is computationally prohibitively expensive.
P95-1050
To conclude with, let us add some speculation by mentioning that the ability to identify word translations from non-parallel texts can be seen as an indicator in favor of the associationist view of human language acquisition (see also Landauer & Dumais, 1997, and Wettler & Rapp, 1993).
W93-0310
These lists were compiled by looking at the closed class words (mainly articles, pronouns, and particles) in an English and a German morphological lexicon (for details see Lezius, Rapp, & Wettler, 1998) and at word frequency lists derived from our corpora.
P98-2123
Many studies show that for nicely parallel corpora high accuracy rates of up to 99% can be achieved for both sentence and word alignment (Gale & Church, 1993; Kay & R/Sscheisen, 1993).
J93-1004 J93-1006
However, in yet unpublished work we found that at least for the computation of synonyms and related words neither syntactical analysis nor singular value decomposition lead to significantly better results than the approach described here when applied to the monolingual case (see also Grefenstette, 1993), so we did not try to include these methods in our system.
W93-0113
For the computation of related terms and synonyms, Ruge (1995), Landauer and Dumais (1997), and Fung and McKeown (1997) used the cosine measure, whereas Grefenstette (1994, p.
W97-0119
In this situation, Rapp (1995) proposed using a clue different from the three mentioned above: His co-occurrence clue is based on the assumption that there is a correlation between cooccurrence patterns in different languages.
P95-1050
However, as Rapp (1995) proposed, this correlation may be strengthened by not using the co-occurrence counts directly, but association strengths between words instead.
P95-1050
After an attempt with a context heterogeneity measure (Fung, 1995) for identifying word translations, Fung based her later work also on the co-occurrence assumption (Fung & Yee, 1998; Fung & McKeown, 1997).
P98-1069 W95-0114 W97-0119

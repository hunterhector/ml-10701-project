4See (Li and Abe, 1998) for a full explanation.
J98-2002
We hope to use these models in tasks such as diathesis alternation detection (McCarthy, 2000; Tsang and Stevenson, 2004) and contrast with WordNet models previously used for this purpose.
A00-2034 W04-0401 W04-2605
376 tained using the same BNC dataset used by Venkatapathy and Joshi which was obtained using Bikel’s parser (Bikel, 2004).
W04-3224
It would also be worthwhile comparing the use of raw data directly, both from the BNC and from google’s Web 1T corpus (Brants and Franz, 2006) since web counts have been shown to outperform the Clark and Weir models on a pseudo-disambiguation task (Keller and Lapata, 2003).
J03-3005
Venkatapathy and Joshi (2005) produced a dataset of verb-object pairs with human judgements of compositionality.
H05-1113
There is scope for experimenting with other approaches such as (Clark and Weir, 2002), however, we feel a type-based approach is worthwhile to avoid the noise introduced from frequent but polysemous arguments and bias from highly frequent arguments which might be part of a multiword rather than a prototypical argument of the predicate in question, for example eat hat.
J02-2003
Further comparison of WNPROTOs and DSPROTOs to other WordNet models are warranted to contrast the effect of our proposal for disambiguation using word types with iterative approaches, particularly those of Clark and Weir (2002).
J02-2003
369 Selectional preferences of predicates have been modelled using the man-made thesaurus WordNet (Fellbaum, 1998), see for example (Resnik, 1993; Li and Abe, 1998; Abney and Light, 1999; Clark and Weir, 2002).
J02-2003 J98-2002 W99-0901
His results were hampered by models based on (Li and Abe, 1998) which involved rather uninformative models at the roots of WordNet.
J98-2002
These features were ob10We show absolute values of correlation following (Venkatapathy and Joshi, 2005).
H05-1113
These features are feature 1 frequency, feature 2 pointwise mutual information, feature 3 based on (Lin, 1999) and feature 7 LSA feature which considers the similarity of the verb-object pair with the verbal form of the object.
P99-1041
The other two methods (we refer to them as ‘typebased’) also calculate a probability distribution using argument head tokens but they select the classes over which the distribution is calculated using the number of argument head types (of a verb in a corpus) in a given class, rather than the number of argument head tokens in contrast to previous WordNet models (Resnik, 1993; Li and Abe, 1998; Clark and Weir, 2002).
J02-2003 J98-2002
least mutual information difference with similar collocations, based on (Lin, 1999) and using Lin’s thesaurus (Lin, 1998) for obtaining the similar collocations.
J98-2002 P98-2127 P99-1041
In this work we are investigate methods of determining semantic compositionality of verb-object 1 combinations on a continuum following previous research in this direction (McCarthy et al., 2003; Venkatapathy and Joshi, 2005).
H05-1113 W03-1810
Characterising the semantic behaviour of phrases in terms of compositionality has particularly attracted attention in recent years (Lin, 1999; Schone and Jurafsky, 2001; Bannard, 2002; Bannard et al., 2003; Baldwin et al., 2003; McCarthy et al., 2003; Bannard, 2005; Venkatapathy and Joshi, 2005).
H05-1113 P99-1041 W01-0513 W03-1809 W03-1810 W03-1812
The parser was also used to extract the grammatical relation data used for acquisition of the thesaurus described below in section 3.3. 3.1 TCMs This approach is a reimplementation of Li and Abe (1998).
J98-2002
6. a latent semantic approach (LSA) based on (Schcurrency1utze, 1998; Baldwin et al., 2003) and considering the dissimilarity of the verb-object pair with its constituent verb 7.
W03-1812
Bikel. 2004.
W04-3224
the same LSA approach, but considering the similarity of the verb-object pair with the verbal form of the object (to capture support verb constructions e.g. give a smile Venkatapathy and Joshi (2005) produced a dataset of verb-object pairs with human judgements of compositionality.
H05-1113
375 signi cantly better correlation with the human goldstandard than any of the features in isolation We evaluated our selectional preference models using the verb-object pairs produced by Venkatapathy and Joshi (2005).
H05-1113
The cluster output can then be used as classes for selectional preferences (Pereira et al., 1993), or one can directly use frequency information from distributionally similar words for smoothing (Grishman and Sterling, 1994).
C94-2119 P93-1024
Venkatapathy and Joshi (2005) combine different statistical and distributional methods using support vector machines (SVMs) for identifying noncompositional verb-object combinations.
H05-1113
Work Most previous work using distributional approaches to compositionality either contrasts distributional information of candidate phrases with constituent words (Schone and Jurafsky, 2001; Bannard et al., 2003; Baldwin et al., 2003; McCarthy et al., 2003) or uses distributionally similar words to detect nonproductive phrases (Lin, 1999).
P99-1041 W01-0513 W03-1809 W03-1810 W03-1812
We applied 4 of the features used by Venkatapathy and Joshi (2005) 11 and described in section 2 to our subset of 638 items.
H05-1113
Lin (1999) used his method (Lin, 1998) for automatic thesaurus construction.
J98-2002 P98-2127 P99-1041
373 Algorithm 1 WNPROTO algorithm C = (){classes in WNPROTO} D = () {disambiguated ty ∈ TY } fD = 0 {frequency of disambiguated items} TY = argument head types {nouns occurring as objects of verb, with associated frequencies} C1 ∈ WordNet where |ty ∈ TY occurring in c ∈ C1| > 1 for all ty ∈ TY do nd c ∈ classes(ty) ∈ C1 where c = argmaxc typeratio(c) if c & c /∈ C then add c to C add ty ↔ c to D {Disambiguated ty with c} end if end for for all c ∈ C do if |ty ↔ c ∈ D| > 1 then fD = fD + frequency(ty){sum frequencies of types under classes to be used in model} else remove c from C {classes with less than two disambiguated nouns are removed} end if end for for all c ∈ C do p(c) = frequency-of-all-tys-disambiguated-to-class(c,D)fD {calculating class probabilities} end for Algorithm 2 DSPROTO algorithm C = (){classes in DSPROTO} D = () {disambiguated ty ∈ TY } fD = 0 {frequency of disambiguated items} TY = argument head types {nouns occurring as objects of verb, with associated frequencies} C1 = cty ∈ TY where num-types-in-thesaurus(cty,TY ) > 1 order C1 by num-types-in-thesaurus(cty,TY ) {classes ordered by coverage of argument head types} for all cty ∈ ordered C1 do Dcty = () {disambiguated for this class} for all ty ∈ TY where in-thesaurus-entry(cty,ty) do if ty /∈ D then add ty to Dcty {types disambiguated to this class only if not disambiguated by a class used already} end if end for if |Dcty| > 1 then add cty to C for all ty ∈ Dcty do add ty ↔ cty to D {Disambiguated ty with cty} fD = fD + frequency(ty) end for end if end for for all cty ∈ C do p(cty) = frequency-of-all-tys-disambiguated-to-class(cty,D)fD {calculating class probabilities} end for 374 3.3 DSPROTOs We use a thesaurus acquired using the method proposed by Lin (1998).
J98-2002 P98-2127
Two use WordNet and the other uses the entries in a thesaurus of distributionally similar words acquired automatically following (Lin, 1998).
J98-2002 P98-2127
The algorithm is described fully by Li and Abe (1998).
J98-2002
Certainly it would be worth combining the preferences with other measures, such as syntactic xedness (Fazly and Stevenson, 2006).
E06-1043
The rst method is due to Li and Abe (1998).
J98-2002
Fazly and Stevenson (2006) use statistical measures of syntactic behaviour to gauge whether a verb and noun combination is likely to be a idiom.
E06-1043
pointwise mutual information (Church and Hanks, 1990), 3.
J90-1003

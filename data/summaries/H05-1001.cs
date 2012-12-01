The approach works as follows: the system identifies the noun phrases which precede the anaphor within a distance of 2 sentences, checks them for gender and number agreement with the anaphor, and then applies genrespecific antecedent indicators to the remaining candidates (Mitkov, 1998).
P98-2143
Resolution Mitkov (1998) developed a robust approach to pronoun resolution which only requires input text to be part-of-speech tagged and noun phrases to be identified.
P98-2143
This second system uses an existing anaphora resolution system to resolve anaphoric expressions, GUITAR (Poesio and Kabadjov, 2004); but, crucially, two different ways of using this information for summarization were tested.
J04-3003
For details see (Radev et al., 2000).
W00-0403
It is a very powerful technique already used for NLP applications such as information retrieval (Berry et al., 1995) and text segmentation (Choi et al., 2001) and, more recently, multiand single-document summarization.
W01-0514
The current version of the system includes an implementation of the MARS pronoun resolution algorithm (Mitkov, 1998) and a partial implementation of the algorithm for resolving definite descriptions proposed by Vieira and Poesio (2000).
J00-4003 P98-2143
The first of these, relative utility (RU) (Radev et al., 2000) allows model summaries to consist of sentences with variable ranking.
W00-0403
3 3.2.2 Definite Description Resolution The Vieira / Poesio algorithm (Vieira and Poesio, 2000) attempts to classify each definite description as either direct anaphora, discourse-new, or bridging description.
J00-4003
Many approaches to summarization can be very broadly characterized as TERM-BASED: they attempt to identify the main ‘topics,’ which generally are TERMS, and then to extract from the document the most important information about these terms (Hovy and Lin, 1997).
W97-0704
These approaches can be divided again very broadly in ‘lexical’ approaches, among which we would include LSA-based approaches, and ‘coreference-based’ approaches. Lexical approaches to term-based summarization use lexical relations to identify central terms (Barzilay and Elhadad, 1997; Gong and Liu, 2002); coreference(or anaphora-) based approaches (Baldwin and Morton, 1998; Boguraev and Kennedy, 1999; Azzam et al., 1999; Bergler et al., 2003; Stuckardt, 2003) identify these terms by running a coreferenceor anaphoric resolver over the text.1 We are not aware, however, of any attempt to use both lexical and anaphoric information to identify the main terms.
W97-0703 W99-0211
3.2 GUITAR: A General-Purpose Anaphoric Resolver The system we used in these experiments, GUITAR (Poesio and Kabadjov, 2004), is an anaphora resolution system designed to be high precision, modular, and usable as an off-the-shelf component of a NL processing pipeline.
J04-3003
The main problem are pronouns, that tend to share the least lexical similarity with the form used to express the antecedent (and anyway are usually removed by stopword lists, therefore do not 2It should be noted that for many newspaper articles, indeed many non-educational texts, only a ‘entity-centered’ structure can be clearly identified, as opposed to a ‘relation-centered’ structure of the type hypothesized in Rhetorical Structures Theory (Knott et al., 2001; Poesio et al., 2004).
J04-3003
with GUITAR To use GUITAR, we first parsed the texts using Charniak’s parser (Charniak, 2000).
A00-2018

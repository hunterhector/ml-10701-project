In the embedded approach, an on-line module which statistically induces the likelihood of a particular string being a word is embedded in a morphological analyzer (Nagata, 1999; Uchimoto et al., 2001).
P99-1036 W01-0512
Nagata (1999) classifies unknown word types based on the character type combination in an unknown word.
P99-1036
The method achieves 42.0% recall and 66.4% precision on EDR corpus 3 . Uchimoto (2001) presents Maximum Entropy based methods.
W01-0512
Zhang (2002) shows a method with role (position) tagging on characters in sentences.
W02-1817
Table 2 shows the unknown word tags for chunking, which are known as the IOB2 model (Ramshaw and Marcus, 1995).
W95-0107
Uchimoto (2003) also adopts their method for CSJ Corpus (Maekawa et al.2000) 6 . They present that the recall for short words on the corpus is 55.7% (928/1,667) (without POS information).
P03-1061
Prec. F-Measure Baseline (50%) 97.7% 96.5% 97.1 Baseline (90%) 97.8% 96.6% 97.2 Our Method 98.5% 98.1% 98.3 4 Related Work Mori (1996) presents a statistical method based on n-gram model for unknown word identification.
C96-2202
Table 1: Tags for positions in a word Tag Description S one-character word B first character in a multi-character word E last character in a multi-character word I intermediate character in a multi-character word (only for words longer than 2 chars) 2.3 Support Vector Machine-based Chunking We use the chunker YamCha (Kudo and Matsumoto, 2001), which is based on SVMs (Vapnik, 1998).
N01-1025
Goh (2003) also uses a characterbased position tagging method by support vector machines.
P03-2039
Previous work of the modular approach was either unable to detect low frequency unknown words (Mori 1996) or limited to predefined character patterns for low frequency unknown words (Ikeya 2000).
C96-2202
For Chinese language, Chen (2002) introduces a method using statistical methods and human-aided rules.
C02-1049
One would argue that, once the word boundaries are identified, the POS guessing method in European language can be applied (Brants 2000; Nakagawa 2001).
A00-1031
In the modular approach, a separate off-line module is used to extract unknown words from text (Mori 1996; Ikeya 2000).
C96-2202

I=0
while( [[ $I -lt 100 ]] ); do
	if [ `expr $I % 3` -eq 0 ] && [ `expr $I % 5` -eq 0 ]; then
		echo fizzbuzz
	elif [ `expr $I % 3` -eq 0 ]; then
		echo buzz
	elif [ `expr $I % 5` -eq 0 ]; then
		echo fizz
	else
		echo $I
	fi
	((I+=1))
done
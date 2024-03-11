<template>
    <div class="bg-[#081012] p-14">
        <div class="flex h-[600px] max-w-[1135px] mx-auto">
            <div class="w-[20%] flex flex-col  justify-start">
                <div class="flex my-7">
                    <img class="max-h-[80px]" src="../../assets/logo.svg" alt=""
                        style="filter: brightness(0) invert(1);">
                    <div class="text-center ">
                        <span class="block tracking-widest">Volunteer</span>
                        <span class="text-2xl font-medium tracking-widest">doctors</span>
                    </div>
                </div>
                <div class="my-7">
                    <img src="../../assets/icons/PhoneIcon.svg" alt="" class="inline mr-3">
                    <span class="text-2xl">0987654321</span>
                </div>
                <div class="my-7">
                    <img src="../../assets/icons/EmailIcon.svg" alt="" class="inline mr-3">
                    <span class="text-2xl">bstn@abc.org</span>
                </div>
                <div class="my-7">
                    <img src="../../assets/icons/PhoneIcon.svg" alt="" class="inline mr-3">
                    <span class="text-2xl">Hà Nội</span>
                </div>
                <div class="my-7">
                    <ul class="flex justify-start">
                        <li><img src="../../assets/icons/facebookIcon.svg" alt="" class="inline mr-3"></li>
                        <li><img src="../../assets/icons/PhoneIcon.svg" alt="" class="inline mr-3"></li>
                        <li><img src="../../assets/icons/PhoneIcon.svg" alt="" class="inline mr-3"></li>
                        <li><img src="../../assets/icons/PhoneIcon.svg" alt="" class="inline mr-3"></li>
                    </ul>
                </div>
                <div class="my-7">
                    <button type="button" class="px-10 py-2 rounded-[40px] border-[3px] border-[#FFB800]"><a
                            href="">Tham gia cùng chúng tôi</a></button>
                </div>
            </div>
            <div class="w-[20%] flex flex-col  justify-start">
                <div class="my-7 h-[80px]">
                    <span class="text-3xl font-medium">Thông tin về chúng tôi</span>
                </div>
                <div class="my-7">
                    <ul>
                        <li class="text-2xl mb  -3">Sức khỏe</li>
                        <li class="text-2xl my-3">Tình nguyện</li>
                        <li class="text-2xl my-3">Blog: tin tức</li>
                        <li class="text-2xl my-3">Tham gia</li>
                    </ul>
                </div>

            </div>
            <div class="w-[20%] flex flex-col  justify-start">
                <div class="my-7 h-[80px]">
                    <span class="text-3xl font-medium">Ai có thể tham gia không?</span>
                </div>
                <div class="my-7">
                    <ul>
                        <li class="text-2xl mb  -3">Y tá</li>
                        <li class="text-2xl my-3">Bác sĩ</li>
                        <li class="text-2xl my-3">Sinh viên</li>
                        <li class="text-2xl my-3">Dược sĩ</li>
                        <li class="text-2xl my-3">Gia đình</li>
                        <li class="text-2xl my-3">Nhóm</li>
                        <li class="text-2xl my-3">Nhà cung cấp dịch vụ y tế</li>
                    </ul>
                </div>

            </div>
            <div class="w-[20%] flex flex-col  justify-start">
                <div class="my-7 h-[80px]">
                    <span class="text-3xl font-medium">Tài nguyên hộ trợ</span>
                </div>
                <div class="my-7">
                    <ul>
                        <li class="text-2xl mb  -3">Chi phí</li>
                        <li class="text-2xl my-3">Hướng dẫn</li>
                        <li class="text-2xl my-3">Dụng cụ y tế</li>
                    </ul>
                </div>

            </div>
            <div class="w-[20%] flex flex-col  justify-start">
                <div class="my-7 h-[80px]">
                    <span class="text-3xl font-medium">Nhận thông báo từ chúng tôi</span>

                </div>
                <div class="my-7">
                    <div class="">
                        <span class="inline-block mb-3 text-2xl">Họ Tên:</span>
                        <input type="text" class="w-full border-[3px] rounded-[20px] py-2 text-[#333]">
                    </div>
                    <div class="my-3">
                        <span class="inline-block mb-3 text-2xl">Email:</span>
                        <input type="text" class="w-full border-[3px] rounded-[20px] py-2">
                    </div>
                </div>
                <div class="my-7">
                    <button type="button" class="px-10 py-2 rounded-[40px] border-[3px] border-[#FFB800]"><a
                            href="">Tham gia cùng chúng tôi</a></button>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    setup() {


        return {}
    }
}
</script>

<style lang="css" scoped>
* :not(input){
    /* border: 1px solid rebeccapurple; */
    color: #fff;
}
</style>